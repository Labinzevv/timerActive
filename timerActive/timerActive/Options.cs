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
        public Options()
        {
            InitializeComponent();
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
    }
}
