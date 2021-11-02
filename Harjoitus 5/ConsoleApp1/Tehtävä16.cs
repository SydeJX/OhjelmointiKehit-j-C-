using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarjousTehtävä
{
    public class Tehtävä16
    {
        public void tehtävä16()
        {

            int forum = 0;
            for (int i = 0; i < 19; i++)
            {

                if (forum < 11)
                {
                    forum++;
                }
                else
                {
                    forum = forum + 11;
                }
                Console.WriteLine(forum);

            }
            Console.ReadLine();


        }

    }
}
