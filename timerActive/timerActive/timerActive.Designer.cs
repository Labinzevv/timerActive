namespace timerActive
{
    partial class timerActive
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.Active = new System.Windows.Forms.CheckBox();
            this.reset = new System.Windows.Forms.Button();
            this.stopWatchLabel = new System.Windows.Forms.Label();
            this.checkMouse = new System.Windows.Forms.CheckBox();
            this.globalTimer = new System.Windows.Forms.Label();
            this.totalTime = new System.Windows.Forms.Label();
            this.NameProcess = new System.Windows.Forms.Label();
            this.inputProcessName = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GetTotalTime = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Active
            // 
            this.Active.AutoSize = true;
            this.Active.Location = new System.Drawing.Point(7, 49);
            this.Active.Name = "Active";
            this.Active.Size = new System.Drawing.Size(56, 17);
            this.Active.TabIndex = 1;
            this.Active.Text = "Active";
            this.Active.UseVisualStyleBackColor = true;
            // 
            // reset
            // 
            this.reset.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.reset.Location = new System.Drawing.Point(0, 238);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(234, 23);
            this.reset.TabIndex = 4;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // stopWatchLabel
            // 
            this.stopWatchLabel.AutoSize = true;
            this.stopWatchLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.stopWatchLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.stopWatchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stopWatchLabel.Location = new System.Drawing.Point(0, 0);
            this.stopWatchLabel.Name = "stopWatchLabel";
            this.stopWatchLabel.Size = new System.Drawing.Size(237, 42);
            this.stopWatchLabel.TabIndex = 5;
            this.stopWatchLabel.Text = "00:00:00:000";
            // 
            // checkMouse
            // 
            this.checkMouse.AutoSize = true;
            this.checkMouse.Location = new System.Drawing.Point(7, 74);
            this.checkMouse.Name = "checkMouse";
            this.checkMouse.Size = new System.Drawing.Size(91, 17);
            this.checkMouse.TabIndex = 6;
            this.checkMouse.Text = "Check mouse";
            this.checkMouse.UseVisualStyleBackColor = true;
            // 
            // globalTimer
            // 
            this.globalTimer.AutoSize = true;
            this.globalTimer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.globalTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 41.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.globalTimer.Location = new System.Drawing.Point(-1, 175);
            this.globalTimer.Name = "globalTimer";
            this.globalTimer.Size = new System.Drawing.Size(243, 63);
            this.globalTimer.TabIndex = 7;
            this.globalTimer.Text = "00:00:00";
            // 
            // totalTime
            // 
            this.totalTime.AutoSize = true;
            this.totalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalTime.Location = new System.Drawing.Point(57, 150);
            this.totalTime.Name = "totalTime";
            this.totalTime.Size = new System.Drawing.Size(112, 25);
            this.totalTime.TabIndex = 8;
            this.totalTime.Text = "Total time:";
            // 
            // NameProcess
            // 
            this.NameProcess.AutoSize = true;
            this.NameProcess.Location = new System.Drawing.Point(4, 98);
            this.NameProcess.Name = "NameProcess";
            this.NameProcess.Size = new System.Drawing.Size(75, 13);
            this.NameProcess.TabIndex = 10;
            this.NameProcess.Text = "Name process";
            // 
            // inputProcessName
            // 
            this.inputProcessName.FormattingEnabled = true;
            this.inputProcessName.Items.AddRange(new object[] {
            "3dsmax",
            "Photoshop"});
            this.inputProcessName.Location = new System.Drawing.Point(91, 95);
            this.inputProcessName.Name = "inputProcessName";
            this.inputProcessName.Size = new System.Drawing.Size(135, 21);
            this.inputProcessName.TabIndex = 13;
            this.inputProcessName.SelectedIndexChanged += new System.EventHandler(this.inputProceccName_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(3, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 27);
            this.panel1.TabIndex = 15;
            // 
            // GetTotalTime
            // 
            this.GetTotalTime.Location = new System.Drawing.Point(59, 126);
            this.GetTotalTime.Name = "GetTotalTime";
            this.GetTotalTime.Size = new System.Drawing.Size(107, 23);
            this.GetTotalTime.TabIndex = 16;
            this.GetTotalTime.Text = "Get the total time";
            this.GetTotalTime.UseVisualStyleBackColor = true;
            this.GetTotalTime.Click += new System.EventHandler(this.GetTotalTime_Click);
            // 
            // timerActive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 261);
            this.Controls.Add(this.GetTotalTime);
            this.Controls.Add(this.NameProcess);
            this.Controls.Add(this.inputProcessName);
            this.Controls.Add(this.totalTime);
            this.Controls.Add(this.globalTimer);
            this.Controls.Add(this.checkMouse);
            this.Controls.Add(this.stopWatchLabel);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.Active);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(250, 300);
            this.MinimumSize = new System.Drawing.Size(250, 300);
            this.Name = "timerActive";
            this.Text = "timerActive";
            this.Load += new System.EventHandler(this.timerActive_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.CheckBox Active;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label stopWatchLabel;
        private System.Windows.Forms.CheckBox checkMouse;
        private System.Windows.Forms.Label globalTimer;
        private System.Windows.Forms.Label totalTime;
        private System.Windows.Forms.Label NameProcess;
        private System.Windows.Forms.ComboBox inputProcessName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button GetTotalTime;
    }
}

