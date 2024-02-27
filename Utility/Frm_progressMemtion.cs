using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Utility
{
    
   
    public partial class Frm_progressMemtion : Form
    {
        public Frm_progressMemtion()
        {
            InitializeComponent();
        }

        public bool finishedFlag = false;
        public void progressBarValue()

        {
            this.progressBar1.Visible = true;
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(Timer1_Tick);
            this.timer1.Start();

            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            if (!finishedFlag)
            {
                this.progressBar1.Value++;
            }
            else
            {
                this.timer1.Stop();
                this.Close();
            }

        }
    }
}
