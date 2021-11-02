using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarjousTehtävä
{
    class Tehtävä5
    {

        public void tehtävä5()
        {
            string username = null;
            Console.Write("What is your username: ");
            username = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Welcome, " + username + " to your computer console.");
            Console.ReadLine();
        }

    }
}
