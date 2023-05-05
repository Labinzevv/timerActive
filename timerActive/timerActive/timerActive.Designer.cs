namespace timerActive
{
    partial class TimerActive
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimerActive));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.windowActive = new System.Windows.Forms.CheckBox();
            this.reset = new System.Windows.Forms.Button();
            this.stopWatchLabel = new System.Windows.Forms.Label();
            this.mouseActive = new System.Windows.Forms.CheckBox();
            this.globalTimer = new System.Windows.Forms.Label();
            this.totalTime = new System.Windows.Forms.Label();
            this.inputProcessName = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.changeProject = new System.Windows.Forms.Button();
            this.addNewProcess = new System.Windows.Forms.Button();
            this.addProject = new System.Windows.Forms.Button();
            this.inputProjectName = new System.Windows.Forms.ComboBox();
            this.addProcess = new System.Windows.Forms.Button();
            this.GetTotalTime = new System.Windows.Forms.Button();
            this.activeProcess = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.activeTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.activeWindowMode = new System.Windows.Forms.CheckBox();
            this.activeMouseMode = new System.Windows.Forms.CheckBox();
            this.options = new System.Windows.Forms.Button();
            this.mouseOverWindow = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // windowActive
            // 
            resources.ApplyResources(this.windowActive, "windowActive");
            this.windowActive.Name = "windowActive";
            this.windowActive.UseVisualStyleBackColor = true;
            // 
            // reset
            // 
            resources.ApplyResources(this.reset, "reset");
            this.reset.Name = "reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // stopWatchLabel
            // 
            resources.ApplyResources(this.stopWatchLabel, "stopWatchLabel");
            this.stopWatchLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.stopWatchLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stopWatchLabel.Name = "stopWatchLabel";
            // 
            // mouseActive
            // 
            resources.ApplyResources(this.mouseActive, "mouseActive");
            this.mouseActive.Name = "mouseActive";
            this.mouseActive.UseVisualStyleBackColor = true;
            // 
            // globalTimer
            // 
            resources.ApplyResources(this.globalTimer, "globalTimer");
            this.globalTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.globalTimer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.globalTimer.Name = "globalTimer";
            // 
            // totalTime
            // 
            resources.ApplyResources(this.totalTime, "totalTime");
            this.totalTime.Name = "totalTime";
            // 
            // inputProcessName
            // 
            this.inputProcessName.FormattingEnabled = true;
            resources.ApplyResources(this.inputProcessName, "inputProcessName");
            this.inputProcessName.Name = "inputProcessName";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.changeProject);
            this.panel1.Controls.Add(this.addNewProcess);
            this.panel1.Controls.Add(this.addProject);
            this.panel1.Controls.Add(this.inputProjectName);
            this.panel1.Controls.Add(this.addProcess);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // changeProject
            // 
            resources.ApplyResources(this.changeProject, "changeProject");
            this.changeProject.Name = "changeProject";
            this.changeProject.UseVisualStyleBackColor = true;
            this.changeProject.Click += new System.EventHandler(this.changeProject_Click);
            // 
            // addNewProcess
            // 
            resources.ApplyResources(this.addNewProcess, "addNewProcess");
            this.addNewProcess.Name = "addNewProcess";
            this.addNewProcess.UseVisualStyleBackColor = true;
            this.addNewProcess.Click += new System.EventHandler(this.addNewProcess_Click);
            // 
            // addProject
            // 
            resources.ApplyResources(this.addProject, "addProject");
            this.addProject.Name = "addProject";
            this.addProject.UseVisualStyleBackColor = true;
            this.addProject.Click += new System.EventHandler(this.addProject_Click);
            // 
            // inputProjectName
            // 
            this.inputProjectName.FormattingEnabled = true;
            resources.ApplyResources(this.inputProjectName, "inputProjectName");
            this.inputProjectName.Name = "inputProjectName";
            this.inputProjectName.SelectedIndexChanged += new System.EventHandler(this.inputProjectName_SelectedIndexChanged);
            // 
            // addProcess
            // 
            resources.ApplyResources(this.addProcess, "addProcess");
            this.addProcess.Name = "addProcess";
            this.addProcess.UseVisualStyleBackColor = true;
            this.addProcess.Click += new System.EventHandler(this.addProcess_Click);
            // 
            // GetTotalTime
            // 
            resources.ApplyResources(this.GetTotalTime, "GetTotalTime");
            this.GetTotalTime.Name = "GetTotalTime";
            this.GetTotalTime.UseVisualStyleBackColor = true;
            this.GetTotalTime.Click += new System.EventHandler(this.GetTotalTime_Click);
            // 
            // activeProcess
            // 
            resources.ApplyResources(this.activeProcess, "activeProcess");
            this.activeProcess.Name = "activeProcess";
            // 
            // label
            // 
            resources.ApplyResources(this.label, "label");
            this.label.Name = "label";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // activeTitle
            // 
            resources.ApplyResources(this.activeTitle, "activeTitle");
            this.activeTitle.Name = "activeTitle";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.activeProcess);
            this.panel2.Controls.Add(this.activeTitle);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.mouseOverWindow);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.windowActive);
            this.panel3.Controls.Add(this.mouseActive);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.activeWindowMode);
            this.panel4.Controls.Add(this.activeMouseMode);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // activeWindowMode
            // 
            resources.ApplyResources(this.activeWindowMode, "activeWindowMode");
            this.activeWindowMode.Name = "activeWindowMode";
            this.activeWindowMode.UseVisualStyleBackColor = true;
            this.activeWindowMode.CheckedChanged += new System.EventHandler(this.activeWindowMode_CheckedChanged);
            // 
            // activeMouseMode
            // 
            resources.ApplyResources(this.activeMouseMode, "activeMouseMode");
            this.activeMouseMode.Name = "activeMouseMode";
            this.activeMouseMode.UseVisualStyleBackColor = true;
            this.activeMouseMode.CheckedChanged += new System.EventHandler(this.mouseMovingMode_CheckedChanged);
            // 
            // options
            // 
            resources.ApplyResources(this.options, "options");
            this.options.Name = "options";
            this.options.UseVisualStyleBackColor = true;
            this.options.Click += new System.EventHandler(this.options_Click);
            // 
            // mouseOverWindow
            // 
            resources.ApplyResources(this.mouseOverWindow, "mouseOverWindow");
            this.mouseOverWindow.Name = "mouseOverWindow";
            this.mouseOverWindow.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // TimerActive
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.options);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.GetTotalTime);
            this.Controls.Add(this.inputProcessName);
            this.Controls.Add(this.totalTime);
            this.Controls.Add(this.globalTimer);
            this.Controls.Add(this.stopWatchLabel);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TimerActive";
            this.Load += new System.EventHandler(this.timerActive_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.CheckBox windowActive;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label stopWatchLabel;
        private System.Windows.Forms.CheckBox mouseActive;
        private System.Windows.Forms.Label globalTimer;
        private System.Windows.Forms.Label totalTime;
        private System.Windows.Forms.ComboBox inputProcessName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button GetTotalTime;
        private System.Windows.Forms.Button addProcess;
        private System.Windows.Forms.Label activeProcess;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label activeTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox activeWindowMode;
        private System.Windows.Forms.CheckBox activeMouseMode;
        private System.Windows.Forms.ComboBox inputProjectName;
        private System.Windows.Forms.Button addProject;
        private System.Windows.Forms.Button addNewProcess;
        private System.Windows.Forms.Button options;
        private System.Windows.Forms.Button changeProject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox mouseOverWindow;
        private System.Windows.Forms.Label label4;
    }
}

