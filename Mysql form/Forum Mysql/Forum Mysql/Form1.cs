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
        private bool Female = false;
    /*
    * Loading
    * Loading Functions
    */ 
        public form1()
        {
            InitializeComponent();
            Female = true;
            Students student = new Students();
            DataGirdView.DataSource = student.GetFemaleStudents();
            CurrentLabel.Text = "Current Table: Famale Table";
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

        private void ButtonChange_Click(object sender, EventArgs e)
        {
            if (Female)
            {
                Female = false;
                Students student = new Students();
                DataGirdView.DataSource = student.GetMaleStudents();
                CurrentLabel.Text = "Current Table: Male Table";
            } else
            {
                Female = true;
                Students student = new Students();
                DataGirdView.DataSource = student.GetFemaleStudents();
                CurrentLabel.Text = "Current Table: Famale Table";
            
            }

          

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            Students student = new Students();
            int YearOld = int.Parse(OldYText.Text);
            string FName = FirstNText.Text;
            string Lname = LastnameText.Text;
            string Email = EmailText.Text;
            string Phone = PhoneText.Text;
            int StudentNumber = int.Parse(TextID.Text);

            if (FName.Trim().Equals("") || Lname.Trim().Equals("") || Phone.Trim().Equals("") || Email.Trim().Equals("") || StudentNumber.Trim().Equals("") || YearOld.Trim().Equals(""))
            {
                MessageBox.Show("Please fill up all the boxes in order to continue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                bool AddStudent = student.AddStudents(YearOld, FName, Lname, Email, Phone, StudentNumber);
                if (AddStudent)
                {
                    
                }
            }






        }



        /*
         * 
         * Functions for the buttons
         */












    }
}

