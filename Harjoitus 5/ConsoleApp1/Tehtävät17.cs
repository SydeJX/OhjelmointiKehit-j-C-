using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarjousTehtävä
{
    public class Tehtävät17
    {

        public void tehtävät17()
        {
            const int luku = 3;
            int change = 0;
            int fer = 0;

            for (int x = 0; x < 11; x++)
            {
                fer = luku * change;
                change++;
                Console.WriteLine(fer);
                
            }
            Console.ReadLine();

        }
    }
}
