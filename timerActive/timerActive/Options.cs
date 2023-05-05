using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace timerActive
{
    public partial class Options : Form
    {
        string en = "En";
        string ru = "Ru";

        public Options()
        {
            InitializeComponent();
            language.SelectedItem = "En";
        }
      
        private void Options_Load(object sender, EventArgs e)
        {
           
        }

        private void Options_FormClosing(object sender, FormClosingEventArgs e)
        {
            TimerActive timerActive = Application.OpenForms.OfType<TimerActive>().FirstOrDefault();
            if (timerActive != null)
            {
                timerActive.Show();
                timerActive.Location = Location;
            }
        }

        private void language_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (language.SelectedItem.ToString() == en)
            {
                enText.Visible = true;
                ruText.Visible = false;
            }
            if (language.SelectedItem.ToString() == ru)
            {
                enText.Visible = false;
                ruText.Visible = true;
            }
        }
    }
}
