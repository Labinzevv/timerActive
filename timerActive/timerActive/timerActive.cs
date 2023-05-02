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
        //[DllImport("user32.dll")]
        //static extern IntPtr GetForegroundWindow();
        //[DllImport("user32.dll")]
        //static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        //возвращает имя процесса
        //[DllImport("user32.dll")]
        //static extern IntPtr GetForegroundWindow();
        //[DllImport("user32.dll")]
        //static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);
        //[DllImport("user32.dll", SetLastError = true)]
        //static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

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
        public string inputnameProcces;
        //путь файла
        string filePath = "3dsmax.txt";

        public timerActive()
        {
            InitializeComponent();

            //подписка на закрытие приложения
            FormClosing += new FormClosingEventHandler(timerActive_FormClosing);
        }
        private void timerActive_Load(object sender, EventArgs e)
        {
            stopwatch = new Stopwatch();

            //сборос секундомера
            stopwatch.Reset();

            //загрузка таймера
            //string filePath = "3dsmax.txt";
            //long savedTicks = 0;
            //if (File.Exists(filePath))
            //{
            //    string savedTimeStr = File.ReadAllText(filePath);
            //    long.TryParse(savedTimeStr, out savedTicks);
            //}
            //long totalTicks = savedTicks + stopwatch.ElapsedTicks;
            //File.WriteAllText(filePath, totalTicks.ToString());
            //TimeSpan totalTime = new TimeSpan(totalTicks);
            //globalTimer.Text = totalTime.ToString("hh':'mm':'ss");

            inputProcessName.SelectedIndexChanged += inputProcessName_SelectedIndexChanged;
        }
        private void inputProcessName_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Вызываем метод для загрузки данных из файла
            LoadDataFromFile();
            inputProcessName.Enabled = false;
        }
        private void LoadDataFromFile()
        {
            // Здесь загружаем данные из файла и выполняем необходимые действия
            //загрузка таймера
            if (inputnameProcces == "3dsmax")
            {
                filePath = "3dsmax.txt";
            }
            if (inputnameProcces == "Photoshop")
            {
                filePath = "Photoshop.txt";
            }
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
            //IntPtr handle = GetForegroundWindow();
            //StringBuilder windowTitle = new StringBuilder(256);
            //GetWindowText(handle, windowTitle, 256);
            //label1.Text = windowTitle.ToString();

            //возвращает имя процесса
            //IntPtr handle = GetForegroundWindow();
            //GetWindowThreadProcessId(handle, out uint pid);
            //Process p = Process.GetProcessById((int)pid);
            //NameProcess.Text = $"Имя процесса: {p.ProcessName}";

            //отслеживает активное окно
            IntPtr hWnd = GetForegroundWindow();
            if (hWnd != IntPtr.Zero)
            {
                int processId;
                GetWindowThreadProcessId(hWnd, out processId);
                Process process = Process.GetProcessById(processId);
                //inputnameProcces - имя процесса
                if (process.ProcessName == inputnameProcces)
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
            //таймер
            stopwatch.Reset();

            if (inputnameProcces == "3dsmax")
            {
                File.WriteAllText("3dsmax.txt", "");
            }
            if (inputnameProcces == "Photoshop")
            {
                File.WriteAllText("Photoshop.txt", "");
            }
            globalTimer.Text = "00:00:00";
        }

        //сохранение таймера
        private void SaveElapsedTime()
        {
            if (inputnameProcces == "3dsmax")
            {
                filePath = "3dsmax.txt";
            }
            if (inputnameProcces == "Photoshop")
            {
                filePath = "Photoshop.txt";
            }   
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
            SaveElapsedTime();
        }

        //ввод данных
        private void inputProceccName_SelectedIndexChanged(object sender, EventArgs e)
        {
            inputnameProcces = inputProcessName.Text;
        }

        //нажатие на кнопку
        private void GetTotalTime_Click(object sender, EventArgs e)
        {
            if (stopwatch.ElapsedTicks > 0)
            {
                if (inputnameProcces == "3dsmax")
                {
                    filePath = "3dsmax.txt";
                }
                if (inputnameProcces == "Photoshop")
                {
                    filePath = "Photoshop.txt";
                }
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

            //if (stopwatch.ElapsedTicks > 0)
            //{
            //    long savedTotalTicks = 0; // сохраненное общее время
            //    stopwatch.Stop();
            //    // вычисляем общее время и сохраняем его в файл
            //    long totalTicks = savedTotalTicks + stopwatch.ElapsedTicks;
            //    File.WriteAllText(filePath, totalTicks.ToString());
            //    // выводим общее время на форму
            //    TimeSpan totalTime = new TimeSpan(totalTicks);
            //    globalTimer.Text = totalTime.ToString("hh':'mm':'ss");
            //    // сбрасываем значения переменных
            //    savedTotalTicks = 0;
            //    File.WriteAllText(filePath, savedTotalTicks.ToString());
            //    stopwatch.Reset();
            //}
        }
    }
}
