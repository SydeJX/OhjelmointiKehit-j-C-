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

        private bool mouseDown;
        private Point lastLocation;
        private bool studentsW;
    /*
    * Loading
    * Loading Functions
    */ 
        public form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, PaintEventArgs e)
        {
            Students student = new Students();
            DataGirdView.DataSource = student.GetFemaleStudents();
            CurrentLabel.Text = "Current Table: Famale Table";

        }

        private void ButtonShut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }


        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void DataGirdView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        /*
         * 
         * Functions for the buttons
         */












    }
}

