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
            this.inputProcessName = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.add = new System.Windows.Forms.Button();
            this.acceptNameProcess = new System.Windows.Forms.Button();
            this.GetTotalTime = new System.Windows.Forms.Button();
            this.activeProcess = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.activeTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.reset.Location = new System.Drawing.Point(0, 239);
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
            this.stopWatchLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.stopWatchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stopWatchLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.globalTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.globalTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 41.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.globalTimer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.globalTimer.Location = new System.Drawing.Point(-4, 152);
            this.globalTimer.Name = "globalTimer";
            this.globalTimer.Size = new System.Drawing.Size(243, 63);
            this.globalTimer.TabIndex = 7;
            this.globalTimer.Text = "00:00:00";
            // 
            // totalTime
            // 
            this.totalTime.AutoSize = true;
            this.totalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalTime.Location = new System.Drawing.Point(57, 123);
            this.totalTime.Name = "totalTime";
            this.totalTime.Size = new System.Drawing.Size(112, 25);
            this.totalTime.TabIndex = 8;
            this.totalTime.Text = "Total time:";
            // 
            // inputProcessName
            // 
            this.inputProcessName.FormattingEnabled = true;
            this.inputProcessName.Location = new System.Drawing.Point(91, 95);
            this.inputProcessName.Name = "inputProcessName";
            this.inputProcessName.Size = new System.Drawing.Size(135, 21);
            this.inputProcessName.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.acceptNameProcess);
            this.panel1.Location = new System.Drawing.Point(3, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 27);
            this.panel1.TabIndex = 15;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(50, 1);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(36, 23);
            this.add.TabIndex = 18;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // acceptNameProcess
            // 
            this.acceptNameProcess.Location = new System.Drawing.Point(1, 1);
            this.acceptNameProcess.Name = "acceptNameProcess";
            this.acceptNameProcess.Size = new System.Drawing.Size(49, 23);
            this.acceptNameProcess.TabIndex = 17;
            this.acceptNameProcess.Text = "Accept";
            this.acceptNameProcess.UseVisualStyleBackColor = true;
            this.acceptNameProcess.Click += new System.EventHandler(this.acceptNameProcess_Click);
            // 
            // GetTotalTime
            // 
            this.GetTotalTime.Location = new System.Drawing.Point(0, 216);
            this.GetTotalTime.Name = "GetTotalTime";
            this.GetTotalTime.Size = new System.Drawing.Size(234, 23);
            this.GetTotalTime.TabIndex = 16;
            this.GetTotalTime.Text = "Get the total time";
            this.GetTotalTime.UseVisualStyleBackColor = true;
            this.GetTotalTime.Click += new System.EventHandler(this.GetTotalTime_Click);
            // 
            // activeProcess
            // 
            this.activeProcess.AutoSize = true;
            this.activeProcess.Location = new System.Drawing.Point(48, 0);
            this.activeProcess.Name = "activeProcess";
            this.activeProcess.Size = new System.Drawing.Size(77, 13);
            this.activeProcess.TabIndex = 18;
            this.activeProcess.Text = "activeProcess ";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(4, 264);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(48, 13);
            this.label.TabIndex = 19;
            this.label.Text = "Process:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Title:";
            // 
            // activeTitle
            // 
            this.activeTitle.AutoSize = true;
            this.activeTitle.Location = new System.Drawing.Point(48, 15);
            this.activeTitle.Name = "activeTitle";
            this.activeTitle.Size = new System.Drawing.Size(56, 13);
            this.activeTitle.TabIndex = 20;
            this.activeTitle.Text = "activeTitle";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.activeProcess);
            this.panel2.Controls.Add(this.activeTitle);
            this.panel2.Location = new System.Drawing.Point(1, 263);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 31);
            this.panel2.TabIndex = 22;
            // 
            // timerActive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 296);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.GetTotalTime);
            this.Controls.Add(this.inputProcessName);
            this.Controls.Add(this.totalTime);
            this.Controls.Add(this.globalTimer);
            this.Controls.Add(this.checkMouse);
            this.Controls.Add(this.stopWatchLabel);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.Active);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(250, 335);
            this.MinimumSize = new System.Drawing.Size(250, 335);
            this.Name = "timerActive";
            this.Text = "Timer active";
            this.Load += new System.EventHandler(this.timerActive_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.ComboBox inputProcessName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button GetTotalTime;
        private System.Windows.Forms.Button acceptNameProcess;
        private System.Windows.Forms.Label activeProcess;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label activeTitle;
        private System.Windows.Forms.Panel panel2;
    }
}

