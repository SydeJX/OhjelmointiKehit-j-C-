using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_tehtävä_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string username = "Jonttu";
        private string password = "Koulu";
        
        private void LoginButton_Click(object sender, EventArgs e)
        {

            string a = null;
            string b = null;

            a = textBox1.Text;
            b = textBox2.Text;

            
            if (UppercaseFirst(a) == username && UppercaseFirst(b) == password)
            {
                MessageBox.Show("Login successful", "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Login Failed, and it went so well", "Surgical Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        static string UppercaseFirst(string s)
        {
            // Check for empty string.
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            // Return char and concat substring.
            return char.ToUpper(s[0]) + s.Substring(1);
        }



    }
}
