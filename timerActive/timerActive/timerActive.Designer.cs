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
            this.global = new System.Windows.Forms.Label();
            this.totalTime = new System.Windows.Forms.Label();
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
            this.Active.Location = new System.Drawing.Point(7, 45);
            this.Active.Name = "Active";
            this.Active.Size = new System.Drawing.Size(56, 17);
            this.Active.TabIndex = 1;
            this.Active.Text = "Active";
            this.Active.UseVisualStyleBackColor = true;
            // 
            // reset
            // 
            this.reset.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.reset.Location = new System.Drawing.Point(0, 243);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(231, 23);
            this.reset.TabIndex = 4;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // stopWatchLabel
            // 
            this.stopWatchLabel.AutoSize = true;
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
            this.checkMouse.Location = new System.Drawing.Point(7, 68);
            this.checkMouse.Name = "checkMouse";
            this.checkMouse.Size = new System.Drawing.Size(91, 17);
            this.checkMouse.TabIndex = 6;
            this.checkMouse.Text = "Check mouse";
            this.checkMouse.UseVisualStyleBackColor = true;
            // 
            // global
            // 
            this.global.AutoSize = true;
            this.global.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.global.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.global.Location = new System.Drawing.Point(0, 182);
            this.global.Name = "global";
            this.global.Size = new System.Drawing.Size(231, 61);
            this.global.TabIndex = 7;
            this.global.Text = "00:00:00";
            // 
            // totalTime
            // 
            this.totalTime.AutoSize = true;
            this.totalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalTime.Location = new System.Drawing.Point(57, 157);
            this.totalTime.Name = "totalTime";
            this.totalTime.Size = new System.Drawing.Size(112, 25);
            this.totalTime.TabIndex = 8;
            this.totalTime.Text = "Total time:";
            // 
            // timerActive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 266);
            this.Controls.Add(this.totalTime);
            this.Controls.Add(this.global);
            this.Controls.Add(this.checkMouse);
            this.Controls.Add(this.stopWatchLabel);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.Active);
            this.Name = "timerActive";
            this.Text = "Form1";
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
        private System.Windows.Forms.Label global;
        private System.Windows.Forms.Label totalTime;
    }
}

