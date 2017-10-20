using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timers = System.Timers;

namespace Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer = new Timers.Timer(500);
            timer.Elapsed += timer_Elapsed;
        }

        void timer_Elapsed(object sender, Timers.ElapsedEventArgs e)
        {
            this.BeginInvoke(new Action(() => { this.label1.Text = DateTime.Now.ToString("HH:mm:ss"); }));
        }
        Timers.Timer timer = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer.Stop();
            timer.Dispose();
        }
    }
}
