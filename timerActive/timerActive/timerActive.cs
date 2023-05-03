using System;
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

namespace timerActive
{
    public partial class timerActive : Form
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
        private string fileName = "inputProcessNameCollection.txt";
        //путь файла
        string filePath = "3dsmax.txt";

        public timerActive()
        {
            InitializeComponent();
            LoadComboBoxValues();
            //подписка на закрытие приложения
            FormClosing += new FormClosingEventHandler(timerActive_FormClosing);
        }
        private void timerActive_Load(object sender, EventArgs e)
        {
            stopwatch = new Stopwatch();

            //сборос секундомера
            stopwatch.Reset();

            //ввод данных в comboBox (после ввода данных, загружаются данные для таймера)
            inputProcessName.SelectedIndexChanged += inputProcessName_SelectedIndexChanged;
        }
        //ввод данных
        private void inputProcessName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Вызывает метод для загрузки данных из файла
            inputNameProcces = inputProcessName.Text;
            LoadDataFromFile();
            acceptNameProcess.Enabled = false;
            inputProcessName.Enabled = false;
        }
        private void LoadDataFromFile()
        {
            //загрузка данных для таймера
            filePath = inputNameProcces + ".txt";
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
                //inputnameProcces - имя процесса
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

            //движение мышки
            POINT currentPoint;
            GetCursorPos(out currentPoint);
            if ((Active.CheckState == CheckState.Checked && currentPoint.x != prevPoint.x)
               ||(Active.CheckState == CheckState.Checked && currentPoint.y != prevPoint.y))
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

            //таймер
            stopWatchLabel.Text = string.Format("{0:hh\\:mm\\:ss\\:fff}", stopwatch.Elapsed);
        }

        private void reset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Really?", "Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //таймер
                stopwatch.Reset();
                //перезаписывает содержимое файла с именем, которое введено в comboBox + ".txt"
                string folderPath = Application.StartupPath; // путь к папке с программой
                string fileName = inputProcessName.Text.Trim(); // имя файла, введенное пользователем
                filePath = Path.Combine(folderPath, fileName); // путь к файлу
                File.WriteAllText(filePath + ".txt", "");
                globalTimer.Text = "00:00:00";
            }
        }
        //сохранение таймера
        private void SaveElapsedTime()
        {
            filePath = inputNameProcces + ".txt";
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
            //сохраняет данные таймера в файл с именем inputNameProcces + ".txt"
            if (stopwatch.ElapsedTicks > 0)
            {
                filePath = inputNameProcces + ".txt";
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
            //загружает введенные в comboBox данные
            if (File.Exists(fileName))
            {
                string[] lines = File.ReadAllLines(fileName);
                inputProcessName.Items.AddRange(lines);
            }
        }
        private void SaveComboBoxValues()
        {
            //создает файл inputProcessNameCollection.txt если его нет
            if (!File.Exists("inputProcessNameCollection.txt"))
            {
                File.Create("inputProcessNameCollection.txt").Close();
            }

            //добавляет в файл inputProcessNameCollection.txt введенные в comboBox данные
            //(если их нет)
            string newItem = inputProcessName.Text.Trim();
            if (!string.IsNullOrEmpty(newItem))
            {
                // Проверяем, содержится ли элемент в файле
                if (!File.ReadAllLines("inputProcessNameCollection.txt").Contains(newItem))
                {
                    // Добавляем строку в файл
                    using (StreamWriter writer = new StreamWriter("inputProcessNameCollection.txt", true))
                    {
                        writer.WriteLine(newItem);
                    }
                }
            }
        }

        //нажатие на кнопку "Get Total Time"
        private void GetTotalTime_Click(object sender, EventArgs e)
        {
            if (stopwatch.ElapsedTicks > 0)
            {
                filePath = inputNameProcces + ".txt";
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
        private void acceptNameProcess_Click(object sender, EventArgs e)
        {
            createNewFileProject();
        }

        void createNewFileProject()
        {      
            string folderPath = Application.StartupPath; // путь к папке с программой
            string fileName = inputProcessName.Text.Trim(); // имя файла, введенное пользователем

            //если у fileName нет суффикса ".txt" то он добавляется
            if (!fileName.EndsWith(".txt"))
            {
                fileName += ".txt";
            }

            filePath = Path.Combine(folderPath, fileName); // путь к файлу

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
                File.Create(inputProcessName.Text + ".txt").Close();
            }
            filePath = "empty.txt";

            if (inputProcessName.Text != "")
            {
                inputProcessName.Enabled = false;
                acceptNameProcess.Enabled = false;
            }
            inputNameProcces = inputProcessName.Text;
        }

        //добавляет введенные в comboBox данные
        private void add_Click(object sender, EventArgs e)
        {
            //создает файл inputProcessNameCollection.txt если его нет
            if (!File.Exists("inputProcessNameCollection.txt"))
            {
                File.Create("inputProcessNameCollection.txt").Close();
            }

            string newProcess = inputProcessName.Text;   
            //проверка на наличие введенных данных
            if (!inputProcessName.Items.Contains(newProcess))
            {
                inputProcessName.Items.Add(newProcess);
                add.Enabled = false;
            }
        }
    }
}
