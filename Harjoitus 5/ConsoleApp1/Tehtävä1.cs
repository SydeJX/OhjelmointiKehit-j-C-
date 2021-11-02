using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarjousTehtävä
{
    public class Tehtävä1
    {


       public void tehtävä1()
        {
            bool success = false;
            int whichisit = 0;
            int a;
            int b;
            string e = null;

            Console.Write("Write down the first number: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Write down the second number: ");
            b = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("What operations do you intend to take\n1. Plus\n2. Minus\n3. Divide");
            e = Console.ReadLine();
            success = int.TryParse(e, out whichisit);
            Console.Clear();

            if (!success)
            {
                switch (e)
                {
                    case "Plus":
                        Console.WriteLine(plus(a, b));
                        Console.ReadLine();
                        break;
                    case "Minus":
                        Console.WriteLine(minus(a, b));
                        Console.ReadLine();
                        break;
                    case "Divide":
                        Console.WriteLine(divide(a, b));
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("You were supposed to use numbers or captilize the first letter.");
                        Console.ReadLine();
                        break;

                }
            }

            if (success)
            {
                switch (whichisit)
                {

                    case 1:
                        Console.WriteLine(plus(a, b));
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine(minus(a, b));
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine(divide(a, b));
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("You didn't choose a correct operation");
                        Console.ReadLine();
                        break;

                }
            }
        }


        static int plus(int a, int b)
        {
            Console.Write(a + " + " + b + " = ");
            int answer = a + b;
            return answer;
        }

        static int minus(int a, int b)
        {
            Console.Write(a + " - " + b + " = ");
            int answer = a - b;
            return answer;
        }

        static int divide(int a, int b)
        {
            Console.Write(a + " / " + b + " = ");
            int answer = a / b;
            return answer;
        }


    }


}
