using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarjousTehtävä
{
    public class Tehtävä15
    {
        
        public void tehtävä15()
        {
            string word;
            string[] themwords;
            do
            {
                Console.Write("\nGive your scary sentence. Write 0 at the end: ");
                word = Console.ReadLine();
                themwords = word.Split(' ');
                foreach (string x in themwords)
                {
                    Console.WriteLine(x);
                }



            } while (word != "0");
            {

            }

            Console.ReadLine();
        }

    }
}
