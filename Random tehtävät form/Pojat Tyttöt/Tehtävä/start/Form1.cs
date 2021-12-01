using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace start
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TarkistaBT_Click(object sender, EventArgs e)
        {
            VastausLB.Visible = false;

            string[] pojat = File.ReadAllLines("C:/Users/jordi/OneDrive/Asiakirjat/GitHub/OhjelmointiKehit-j-C-/Random tehtävät form/Pojat Tyttöt/Pojat.txt");
            string[] tytöt = File.ReadAllLines("C:/Users/jordi/OneDrive/Asiakirjat/GitHub/OhjelmointiKehit-j-C-/Random tehtävät form/Pojat Tyttöt/Tytöt.txt");
            string nimi = NimiTB.Text;
            int number = 1;
            int numberI = 1;

            foreach (string poika in pojat)
            {

                if (nimi == poika)
                {
                    VastausLB.Visible = true;
                    VastausLB.Text = "Nimesi on " + number + ", suosituin poikien nimi vuonna 2020";
                }
                number++;
            }

            foreach (string tyttö in tytöt)
            {

                if (nimi == tyttö)
                {
                    VastausLB.Visible = true;
                    VastausLB.Text = "Nimesi on " + number + ", suosituin poikien nimi vuonna 2020";
                }
                numberI++;
            }

            if (VastausLB.Visible == false) {
                VastausLB.Text = "Nimesi ei löytynyt suosituimpien nimien joukosta! :-(";
                VastausLB.Visible = true;
            }


        }
    }
}
