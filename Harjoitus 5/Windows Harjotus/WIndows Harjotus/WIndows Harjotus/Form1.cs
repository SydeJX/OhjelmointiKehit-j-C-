using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WIndows_Harjotus
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 forum = new Form1();
            Random rnd = new Random();
            Point point1 = new Point();
            int randomizer = 0;
            randomizer = rnd.Next(-100, 900);
            point1.X = randomizer;
            randomizer = rnd.Next(-100, 900);
            point1.X = randomizer;
            this.Location = new Point(point1.X, Location.X);
            this.Location = new Point(point1.Y, Location.X);





        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
