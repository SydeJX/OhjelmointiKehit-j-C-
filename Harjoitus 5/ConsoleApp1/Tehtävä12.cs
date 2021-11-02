using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarjousTehtävä
{
    class Tehtävä12
    {


        public void tehtävä12()
        {

            Console.WriteLine("Write down a number please: ");
            int a = int.Parse(Console.ReadLine());
            int b = a;
            a++;
            for (int i = 0; i < a; i++)
            {
                Console.Write(b + " ");
            }
            Console.ReadLine();

        }




    }
}
