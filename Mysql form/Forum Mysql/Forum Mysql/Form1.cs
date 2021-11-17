using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forum_Mysql
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, PaintEventArgs e)
        {

            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.Black, ButtonBorderStyle.Solid);

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            
        }
        private void ButtonShut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;

        }


        private void button1_MouseHover(object sender, EventArgs e)
        {

            button1.BackColor = Color.Red;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
