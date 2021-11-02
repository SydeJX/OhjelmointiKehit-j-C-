using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarjousTehtävä
{
    public class Tehtävä14
    {


        public void tehtävä14()
        {

            Console.Write("Write down two numbers: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            EvenorOdd(a,b);

        }

         void EvenorOdd(int input, int input2)
        {
            if (input <= 1 && input2 <= 1)
            {
                Console.WriteLine("Both are Negative");
                Console.ReadLine();
            } else if (input >= 1 && input2 >= 1) {
                Console.WriteLine("Both are Postive");
                Console.ReadLine();
            }

            if (input <= 1 && input2 >= 1)
            {
                Console.WriteLine("Another is Negative while the other is positive");
                Console.ReadLine();
            }
            else if (input <= 1 && input2 >= 1)
            {
                Console.WriteLine("Another is Negative while the other is positive");
                Console.ReadLine();
            }

           
        }

    }
}
