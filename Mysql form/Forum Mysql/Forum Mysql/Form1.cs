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
        Students student = new Students();
        public int count = 1;
        public bool error = false;
        /*
        * Loading
        * Loading Functions
        */
        public form1()
        {
            InitializeComponent();
            Female = true;
            DataGirdView.DataSource = student.GetFemaleStudents();
            CurrentLabel.Text = "Current Table: Famale Table";
            if (DataGirdView == null || DataGirdView.Rows.Count == 0)
            {
                CurrentLabel.Text = "Error: Couldn't connect to the table!";
            }

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
                DataGirdView.DataSource = student.GetMaleStudents();
                CurrentLabel.Text = "Current Table: Male Table";
            } else {
                Female = true;
                DataGirdView.DataSource = student.GetFemaleStudents();
                CurrentLabel.Text = "Current Table: Famale Table";
            
            }

           if (DataGirdView == null || DataGirdView.Rows.Count == 0)
            {
                
                switch (count)
                {
                    
                    case 3:
                        CurrentLabel.Text = "Error: Are you Serious?!";
                        count++;
                        break;
                    case 5:
                        CurrentLabel.Text = "Error: Bruh...";
                        count++;
                        break;
                    case 7:
                        CurrentLabel.Text = "Error: I just told you, that I can't connect!!!";
                        count++;
                        break;
                    case 8:
                        CurrentLabel.Text = "Error: Stop, your slowing down process memory, I think....";
                        count++;
                        break;
                    case 9:
                        CurrentLabel.Text = "Error: I Swear! One more time and I'll quit.";
                        count++;
                        break;
                    case 10:
                        CurrentLabel.Text = "Error: Forget this, Imma spam.";
                        ButtonChange.Enabled = false;
                        timer1.Start();
                        break;
                    default:
                        count++;
                        CurrentLabel.Text = "Error: Couldn't connect to the table!";
                        break;
                }
                
            }else
            {
                count = 1;
            }

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            int YearOld = 0;
            int StudentNumber = 0;
            string Phone = null;
            string Email = null;
            string Lname = null;
            string FName = null;
            try
            {
                 YearOld = int.Parse(OldYText.Text);
                 FName = FirstNText.Text;
                 Lname = LastnameText.Text;
                 Email = EmailText.Text;
                 Phone = PhoneText.Text;
                 StudentNumber = int.Parse(StudentText.Text);
                error = false;
            } catch (Exception ex)
            {
                CorrectPicture.BackColor = Color.Red;
                CorrectPicture.Show();
                timer2.Start();
                MessageBox.Show("There might be a character in the wrong box, please remove it","Error from System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }

            if (Female && !error)
            {

                if (FName.Trim().Equals("") || Lname.Trim().Equals("") || Phone.Trim().Equals("") || Email.Trim().Equals("") || StudentNumber.Equals("") || YearOld.Equals(""))
                {
                    CorrectPicture.BackColor = Color.Red;
                    CorrectPicture.Show();
                    timer2.Start();
                    CurrentLabel.Text = "Error: Please fill up all the boxes in order to continue";
                    error = true;
                }
                else
                {
                    bool AddStudent = student.AddStudentsFemale(YearOld, FName, Lname, Email, Phone, StudentNumber);
                    if (AddStudent)
                    {
                        CurrentLabel.Text = "Succeeded";
                    }
                    else
                    {
                        CurrentLabel.Text = "Couldn't insert anyone into the form";
                    }
                }
            } else if (!Female && !error)
            {
                if (FName.Trim().Equals("") || Lname.Trim().Equals("") || Phone.Trim().Equals("") || Email.Trim().Equals("") || StudentNumber.Equals("") || YearOld.Equals(""))
                {
                    CorrectPicture.BackColor = Color.Red;
                    CorrectPicture.Show();
                    timer2.Start();
                    CurrentLabel.Text = "Error: Please fill up all the boxes in order to continue";
                    error = true;
                }
                else
                {
                    bool AddStudent = student.AddStudentsMale(YearOld, FName, Lname, Email, Phone, StudentNumber);
                    if (AddStudent)
                    {
                        CurrentLabel.Text = "Succeeded";
                    }
                    else
                    {
                        CorrectPicture.BackColor = Color.Red;
                        CorrectPicture.Show();
                        timer2.Start();
                        CurrentLabel.Text = "Error: Couldn't insert anyone into the form";
                    }
                }
            }


        }

            

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                MessageBox.Show("STOP!!!", "Message From Admin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.Close();
            timer1.Stop();
           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (error)
            {
                CorrectPicture.Hide();
                CorrectPicture.BackColor = Color.Green;
                error = false;
                timer2.Stop();

            } else
            {
                CorrectPicture.Hide();
                timer2.Stop();
            }

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string idelet = StudentText.Text;
            if (Female)
            {
                if (student.DeleteStudentFemale(idelet))
                    CurrentLabel.Text = "Successfully deleted Female Student";
                else
                    CurrentLabel.Text = "Error: Failed to deleted because such user doesn't exist";

            } else if (!Female)
            {
                if (student.DeleteStudentMale(idelet))
                    CurrentLabel.Text = "Successfully deleted Male Student";
                else
                    CurrentLabel.Text = "Error: Failed to deleted because such user doesn't exist";
            }
        }

        private void labelEmail_Click(object sender, EventArgs e)
        {

        }

    



        /*
         * 
         * Functions for the buttons
         */












    }
}

