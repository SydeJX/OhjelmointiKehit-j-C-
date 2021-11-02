using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarjousTehtävä
{
    public class Tehtävä13
    {


        public void tehtävä13()
        {

            string nimi = null;
            Console.Write("Write your name to the console: ");
            nimi = Console.ReadLine();
            Console.Clear();
            Console.Write(Reverse(nimi));
            Console.ReadLine();
        }


        public string Reverse(string input)
        {
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);

            return new string(chars);
        }
        


    }
}
