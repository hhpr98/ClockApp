using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            now = DateTime.Now;
            myClock.setDateTime(now.Hour, now.Minute, now.Second, now.Day, now.Month, now.Year);
            StartTimer();
        }


        System.Windows.Forms.Timer t = null;
        DateTime now;

        private void StartTimer()
        {

            t = new System.Windows.Forms.Timer();
            t.Interval = 1000;
            t.Tick += T_Tick;
            t.Enabled = true;
        }

        private void T_Tick(object sender, EventArgs e)
        {
            now = DateTime.Now;
            myClock.setDateTime(now.Hour, now.Minute, now.Second, now.Day, now.Month, now.Year);
        }
    }
}
