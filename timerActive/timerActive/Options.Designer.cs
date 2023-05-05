namespace timerActive
{
    partial class Options
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.panel = new System.Windows.Forms.Panel();
            this.ruText = new System.Windows.Forms.Label();
            this.enText = new System.Windows.Forms.Label();
            this.language = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.ruText);
            this.panel.Controls.Add(this.enText);
            this.panel.Location = new System.Drawing.Point(0, 22);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(236, 364);
            this.panel.TabIndex = 2;
            // 
            // ruText
            // 
            this.ruText.AutoSize = true;
            this.ruText.Location = new System.Drawing.Point(-1, 1);
            this.ruText.Name = "ruText";
            this.ruText.Size = new System.Drawing.Size(218, 689);
            this.ruText.TabIndex = 1;
            this.ruText.Text = resources.GetString("ruText.Text");
            // 
            // enText
            // 
            this.enText.AutoSize = true;
            this.enText.Location = new System.Drawing.Point(-1, 1);
            this.enText.Name = "enText";
            this.enText.Size = new System.Drawing.Size(218, 533);
            this.enText.TabIndex = 0;
            this.enText.Text = resources.GetString("enText.Text");
            // 
            // language
            // 
            this.language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.language.FormattingEnabled = true;
            this.language.Items.AddRange(new object[] {
            "En",
            "Ru"});
            this.language.Location = new System.Drawing.Point(189, 0);
            this.language.Name = "language";
            this.language.Size = new System.Drawing.Size(45, 21);
            this.language.TabIndex = 3;
            this.language.SelectedIndexChanged += new System.EventHandler(this.language_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Language:";
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 386);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.language);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(250, 425);
            this.MinimumSize = new System.Drawing.Size(250, 425);
            this.Name = "Options";
            this.Text = "Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Options_FormClosing);
            this.Load += new System.EventHandler(this.Options_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label enText;
        private System.Windows.Forms.ComboBox language;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ruText;
    }
}