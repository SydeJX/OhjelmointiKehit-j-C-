using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarjousTehtävä
{
    class Tehtävä10
    {

        public void tehtävä10()
        {

            int answernumber;
            Console.Write("Please write the number you want to be calculated: ");
            answernumber = int.Parse(Console.ReadLine());
            for (int num = 1; num < 11; num++)
            {
                Console.Write(answernumber + " * " + num + " = ");
                Console.Write(answernumber * num + "\n");
            }
            Console.Read();



        }


    }
}
