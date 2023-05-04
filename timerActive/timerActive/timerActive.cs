﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading;

namespace timerActive
{
    public partial class TimerActive : Form
    {
        //отслеживает активность приложения по window title
        //[DllImport("user32.dll")]
        //static extern IntPtr GetForegroundWindow();
        //[DllImport("user32.dll")]
        //static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        //возвращает window title
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundTitle();
        [DllImport("user32.dll")]
        static extern int GetWindowTitle(IntPtr hWnd, StringBuilder text, int count);

        //возвращает имя процесса
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundProc();
        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);
        [DllImport("user32.dll", SetLastError = true)]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        //отслеживает активное окно
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int GetWindowThreadProcessId(IntPtr hWnd, out int lpdwProcessId);

        //таймер
        private Stopwatch stopwatch;

        //движение мышки
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCursorPos(out POINT lpPoint);
        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int x;
            public int y;
        }
        private POINT prevPoint;

        //ввод данных
        public string inputNameProcces;
        private string fileProcessName = "inputProcessNameCollection.txt";
        private string fileProjectName = "inputProjectNameCollection.txt";
        //для контроля режима работы приложения
        //(таймер активируется только при движении или при активном окне)
        bool mouseMoveMode = true;
        //для последовательности ввода данных(сначала имя проекта потом имя процесса)
        bool sequenceProcesses = false;

        public TimerActive()
        {
            InitializeComponent();
            LoadComboBoxValues();

            if (sequenceProcesses == false)
            {
                addProcess.Enabled = false;
                inputProcessName.Enabled = false;
            }

            //подписка на закрытие приложения
            FormClosing += new FormClosingEventHandler(timerActive_FormClosing);
            // Подписываемся на событие перемещения формы 1
        }
        private void timerActive_Load(object sender, EventArgs e)
        {
            stopwatch = new Stopwatch();
            mouseMovingMode.CheckState = CheckState.Checked;
            //сборос секундомера
            stopwatch.Reset();

            //ввод данных в comboBox (после ввода данных, загружаются данные для таймера)
            inputProcessName.SelectedIndexChanged += inputProcessName_SelectedIndexChanged;
            inputProjectName.SelectedIndexChanged += inputProjectName_SelectedIndexChanged;
        }
        //ввод данных
        private void inputProcessName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Вызывает метод для загрузки данных из файла
            inputNameProcces = inputProcessName.Text;
            LoadDataFromFile();
            addProcess.Enabled = false;
            inputProcessName.Enabled = false;
        }
        private void inputProjectName_SelectedIndexChanged(object sender, EventArgs e)
        {
            addProject.Enabled = false;
            inputProjectName.Enabled = false;
            addProcess.Enabled = true;
            inputProcessName.Enabled = true;
        }
        //загрузка данных для таймера
        private void LoadDataFromFile()
        {
            string processName = inputProcessName.Text.Trim(); // имя файла, введенное пользователем
            string projectFolder = inputProjectName.Text; // имя папки проекта
            string folderPath = Path.Combine(Application.StartupPath, projectFolder); // создает путь к папке
            string filePath = Path.Combine(folderPath, processName); // создаем путь к файлу
            filePath = filePath + ".txt";

            long savedTicks = 0;
            if (File.Exists(filePath))
            {
                string savedTimeStr = File.ReadAllText(filePath);
                long.TryParse(savedTimeStr, out savedTicks);
            }
            long totalTicks = savedTicks + stopwatch.ElapsedTicks;
            File.WriteAllText(filePath, totalTicks.ToString());
            TimeSpan totalTime = new TimeSpan(totalTicks);
            globalTimer.Text = totalTime.ToString("hh':'mm':'ss");
        }
        //метод таймера
        private void timer_Tick(object sender, EventArgs e)
        {
            //отслеживает активность приложения по window title
            //IntPtr handle = GetForegroundWindow();
            //StringBuilder windowTitle = new StringBuilder(256);
            //GetWindowText(handle, windowTitle, 256);
            //if (windowTitle.ToString() == "Часы")
            //{
            //    label1.Text = "Калькулятор активен";
            //}
            //else
            //{
            //    label1.Text = "Калькулятор неактивен";
            //}

            //возвращает window title
            IntPtr handleTitle = GetForegroundWindow();
            StringBuilder windowTitle = new StringBuilder(256);
            GetWindowText(handleTitle, windowTitle, 256);
            activeTitle.Text = windowTitle.ToString();

            //возвращает имя процесса
            IntPtr handleProc = GetForegroundWindow();
            GetWindowThreadProcessId(handleProc, out uint pid);
            Process p = Process.GetProcessById((int)pid);
            activeProcess.Text = $"{p.ProcessName}";

            //отслеживает активное окно
            IntPtr hWnd = GetForegroundWindow();
            if (hWnd != IntPtr.Zero)
            {
                int processId;
                GetWindowThreadProcessId(hWnd, out processId);
                Process process = Process.GetProcessById(processId);
                //inputNameProcces - имя процесса
                if (process.ProcessName == inputNameProcces)
                {
                    Active.CheckState = CheckState.Checked;
                    stopwatch.Start();

                }
                else
                {
                    Active.CheckState = CheckState.Unchecked;
                    stopwatch.Stop();
                }
            }
            else
            {
                Active.CheckState = CheckState.Unchecked;
                stopwatch.Stop();
            }
            //режим движения мышки вкл/выкл
            if (mouseMoveMode == true)
            {
                POINT currentPoint;
                GetCursorPos(out currentPoint);
                if ((Active.CheckState == CheckState.Checked && currentPoint.x != prevPoint.x)
                   || (Active.CheckState == CheckState.Checked && currentPoint.y != prevPoint.y))
                {
                    checkMouse.CheckState = CheckState.Checked;
                    stopwatch.Start();
                }
                else
                {
                    checkMouse.CheckState = CheckState.Unchecked;
                    stopwatch.Stop();
                }
                prevPoint = currentPoint;
            }

            //таймер
            stopWatchLabel.Text = string.Format("{0:hh\\:mm\\:ss\\:fff}", stopwatch.Elapsed);
        }
        //сброс таймера
        private void reset_Click(object sender, EventArgs e)
        {
            string processName = inputProcessName.Text.Trim(); // имя файла, введенное пользователем
            string projectFolder = inputProjectName.Text; // имя папки проекта
            string folderPath = Path.Combine(Application.StartupPath, projectFolder); // создает путь к папке
            string filePath = Path.Combine(folderPath, processName); // создаем путь к файлу
            filePath = filePath + ".txt";

            DialogResult result = MessageBox.Show("Really?", "Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //таймер
                stopwatch.Reset();
                //перезаписывает содержимое файла с именем, которое введено в comboBox + ".txt"
                File.WriteAllText(filePath, "");
                globalTimer.Text = "00:00:00";
            }
        }
        //сохранение таймера
        private void SaveElapsedTime()
        {
            string processName = inputProcessName.Text.Trim(); // имя файла, введенное пользователем
            string projectFolder = inputProjectName.Text; // имя папки проекта
            string folderPath = Path.Combine(Application.StartupPath, projectFolder); // создает путь к папке
            string filePath = Path.Combine(folderPath, processName); // создаем путь к файлу
            filePath = filePath + ".txt";

            long elapsedTicks = stopwatch.ElapsedTicks + GetSavedElapsedTimeTicks(filePath);
            SaveElapsedTimeTicks(filePath, elapsedTicks);
        }
        private long GetSavedElapsedTimeTicks(string filePath)
        {
            if (!File.Exists(filePath))
                return 0;

            string elapsedTicksStr = File.ReadAllText(filePath);
            if (long.TryParse(elapsedTicksStr, out long elapsedTicks))
                return elapsedTicks;

            return 0;
        }
        private void SaveElapsedTimeTicks(string filePath, long elapsedTicks)
        {
            File.WriteAllText(filePath, elapsedTicks.ToString());
        }
        private void timerActive_FormClosing(object sender, FormClosingEventArgs e)
        {
            string processName = inputProcessName.Text.Trim(); // имя файла, введенное пользователем
            string projectFolder = inputProjectName.Text; // имя папки проекта
            string folderPath = Path.Combine(Application.StartupPath, projectFolder); // создает путь к папке
            string filePath = Path.Combine(folderPath, processName); // создаем путь к файлу
            filePath = filePath + ".txt";

            foreach (TimerActive childForm in this.MdiChildren)
            {
                childForm.Close();
            }

            //сохраняет данные таймера в файл с именем inputNameProcces + ".txt"
            if (stopwatch.ElapsedTicks > 0)
            {
                long savedTicks = 0;
                if (File.Exists(filePath))
                {
                    string savedTimeStr = File.ReadAllText(filePath);
                    long.TryParse(savedTimeStr, out savedTicks);
                }
                long totalTicks = savedTicks + stopwatch.ElapsedTicks;
                File.WriteAllText(filePath, totalTicks.ToString());
            }
            //если пользователь ничего не ввел или если пользователь 
            //что-то ввел но не нажал кнопку acceptNameProcess,
            //то переменная filePath = "empty.txt" и ничего не сохраняется
            if (inputProcessName.Text == "" || !File.Exists(inputProcessName.Text))
            {
                filePath = "empty.txt";
            }  
            else
            {
                SaveElapsedTime();
            }
            //метод сохранения введенных в comboBox данных
            SaveComboBoxValues();
        }
        
        private void LoadComboBoxValues()
        {
            //загружает введенные в comboBox inputProcessName данные
            if (File.Exists(fileProcessName))
            {
                string[] lines = File.ReadAllLines(fileProcessName);
                inputProcessName.Items.AddRange(lines);
            }
            //загружает введенные в comboBox inputProjectName данные
            if (File.Exists(fileProjectName))
            {
                string[] lines = File.ReadAllLines(fileProjectName);
                inputProjectName.Items.AddRange(lines);
            }
           
        }
        private void SaveComboBoxValues()
        {
            //создает файл inputProcessNameCollection.txt если его нет
            if (!File.Exists("inputProcessNameCollection.txt"))
            {
                File.Create("inputProcessNameCollection.txt").Close();
            }
            //создает файл inputProjectNameCollection.txt если его нет
            if (!File.Exists("inputProjectNameCollection.txt"))
            {
                File.Create("inputProjectNameCollection.txt").Close();
            }

            //добавляет в файл inputProcessNameCollection.txt введенные в comboBox данные
            //(если их нет)
            string newItemProcess = inputProcessName.Text.Trim();
            if (!string.IsNullOrEmpty(newItemProcess))
            {
                // Проверяем, содержится ли элемент в файле
                if (!File.ReadAllLines("inputProcessNameCollection.txt").Contains(newItemProcess))
                {
                    // Добавляем строку в файл
                    using (StreamWriter writer = new StreamWriter("inputProcessNameCollection.txt", true))
                    {
                        writer.WriteLine(newItemProcess);
                    }
                }
            }

            //добавляет в файл inputProjectNameCollection.txt введенные в comboBox данные
            //(если их нет)
            string newItemProject = inputProjectName.Text.Trim();
            if (!string.IsNullOrEmpty(newItemProject))
            {
                // Проверяем, содержится ли элемент в файле
                if (!File.ReadAllLines("inputProjectNameCollection.txt").Contains(newItemProject))
                {
                    // Добавляем строку в файл
                    using (StreamWriter writer = new StreamWriter("inputProjectNameCollection.txt", true))
                    {
                        writer.WriteLine(newItemProject);
                    }
                }
            }
        }
        //нажатие на кнопку "Get Total Time"
        private void GetTotalTime_Click(object sender, EventArgs e)
        {
            if (stopwatch.ElapsedTicks > 0)
            {
                string processName = inputProcessName.Text.Trim(); // имя файла, введенное пользователем
                string projectFolder = inputProjectName.Text; // имя папки проекта
                string folderPath = Path.Combine(Application.StartupPath, projectFolder); // создает путь к папке
                string filePath = Path.Combine(folderPath, processName); // создаем путь к файлу
                filePath = filePath + ".txt";

                //filePath = inputNameProcces + ".txt";
                long savedTicks = 0;
                if (File.Exists(filePath))
                {
                    string savedTimeStr = File.ReadAllText(filePath);
                    long.TryParse(savedTimeStr, out savedTicks);
                }
                long totalTicks = savedTicks + stopwatch.ElapsedTicks;
                File.WriteAllText(filePath, totalTicks.ToString());
                TimeSpan totalTime = new TimeSpan(totalTicks);
                globalTimer.Text = totalTime.ToString("hh':'mm':'ss");
                stopwatch.Reset();
            }
        }
        //создание нового файла проекта
        private void addProcess_Click(object sender, EventArgs e)
        {
            //создает файл inputProcessNameCollection.txt если его нет
            if (!File.Exists("inputProcessNameCollection.txt"))
            {
                File.Create("inputProcessNameCollection.txt").Close();
            }

            string processName = inputProcessName.Text.Trim(); // имя файла, введенное пользователем
            string projectFolder = inputProjectName.Text; // имя папки проекта
            string folderPath = Path.Combine(Application.StartupPath, projectFolder); // создает путь к папке
            string filePath = Path.Combine(folderPath, processName); // создаем путь к файлу

            //проверка на наличие введенных данных в comboBox inputProcessName
            if (!inputProcessName.Items.Contains(processName))
            {
                inputProcessName.Items.Add(processName);
            }

            //если у fileName нет суффикса ".txt" то он добавляется
            if (!fileProcessName.EndsWith(".txt"))
            {
                fileProcessName += ".txt";
            }

            if (File.Exists(filePath))
            {
                //загрузка данных для таймера
                long savedTicks = 0;
                string savedTimeStr = File.ReadAllText(filePath);
                long.TryParse(savedTimeStr, out savedTicks);
                long totalTicks = savedTicks + stopwatch.ElapsedTicks;
                TimeSpan totalTime = new TimeSpan(totalTicks);
                globalTimer.Text = totalTime.ToString("hh':'mm':'ss");
            }
            else
            {
                //создание файла процесса
                File.Create(filePath + ".txt").Close();
            }
            filePath = "empty.txt";

            if (inputProcessName.Text != "")
            {
                inputProcessName.Enabled = false;
                addProcess.Enabled = false;
            }
            inputNameProcces = inputProcessName.Text;
        }

        //режимы работы программы (mouse moving mode, active window mode)
        private void mouseMovingMode_CheckedChanged(object sender, EventArgs e)
        {
            if (mouseMovingMode.CheckState == CheckState.Checked)
            {
                activeWindowMode.CheckState = CheckState.Unchecked;
                mouseMoveMode = true;
            }
        }
        private void activeWindowMode_CheckedChanged(object sender, EventArgs e)
        {
            if (activeWindowMode.CheckState == CheckState.Checked)
            {
                mouseMovingMode.CheckState = CheckState.Unchecked;
                mouseMoveMode = false;
            }
        }
        //добавляет папку для проекта
        private void addProject_Click(object sender, EventArgs e)
        {
            if (!File.Exists("inputProjectNameCollection.txt"))
            {
                File.Create("inputProjectNameCollection.txt").Close();
            }

            string newProject = inputProjectName.Text;
            //проверка на наличие введенных данных
            if (!inputProjectName.Items.Contains(newProject))
            {
                inputProjectName.Items.Add(newProject);
            }

            if (!Directory.Exists(inputProjectName.Text) && inputProjectName.Text != "")
            {
                Directory.CreateDirectory(inputProjectName.Text);
            }
            addProject.Enabled = false;
            inputProjectName.Enabled = false;

            addProcess.Enabled = true;
            inputProcessName.Enabled = true;
        }

        //изменить проект и процесс
        private void changeProject_Click(object sender, EventArgs e)
        {
            if (inputProjectName.Text != "" && inputProcessName.Text != "")
            {
                addProject.Enabled = true;
                inputProjectName.Enabled = true;
            }
        }

        //открывает TimerActive 
        private void addNewProcess_Click(object sender, EventArgs e)
        {
            //путь к .ехе этого приложения
            string appPath = Application.ExecutablePath;
            Process.Start(appPath);
        }

        private void options_Click(object sender, EventArgs e)
        {
            Options options = new Options();
            Hide();
            options.Show();
            options.Location = Location;
        }
    }
}
