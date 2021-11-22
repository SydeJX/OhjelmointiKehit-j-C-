using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_tehtävä_form
{
    public partial class Form1 : Form
    {

        List<int> jono = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void LukuText_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (LukuText.Text == "-999")
                {
                    AnswerLabel.Text = "";
                    int[] table = jono.ToArray();
                    foreach(var vase in table)
                    {
                        AnswerLabel.Text += vase + " ";
                    }
                    AnswerLabel.Show();

                }
                else
                {
                    jono.Add(Int32.Parse(LukuText.Text));
                    LukuText.Text = "";
                }
                if (e.KeyChar == (char)Keys.Escape)
                {
                    EmptyPaper();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AnswerLabel.Hide();
            
        }
        private void EmptyPaper()
        {
            LukuText.Text = "";
        }
    }
}
