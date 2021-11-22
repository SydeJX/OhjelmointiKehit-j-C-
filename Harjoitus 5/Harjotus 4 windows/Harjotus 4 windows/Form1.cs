using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjotus_4_windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var Time = DateTime.Now.ToString();
            label7.Text = Time;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DateTime nyt = DateTime.Now;
            DateTime birthday = dateTimePicker1.Value;
            double yearsbeen = Math.Round((nyt - birthday).TotalDays);

            yearsbeen = yearsbeen / 365.25;
            label1.Text = yearsbeen + " Years";







        }
    }
}
