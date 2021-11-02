using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarjousTehtävä
{
    public class Program
    {
         static void Main(string[] args)
        {
            int num = 0;
            bool Start = true;
            //meowoooooiuupåoåpoåpoåoåp
            Tehtävä1 t1 = new Tehtävä1();
            Tehtävä2 t2 = new Tehtävä2();
            Tehtävä5 t5 = new Tehtävä5();
            Tehtävä10 t10 = new Tehtävä10();
            Tehtävä11 t11 = new Tehtävä11();
            Tehtävä12 t12 = new Tehtävä12();
            Tehtävä13 t13 = new Tehtävä13();
            Tehtävä14 t14 = new Tehtävä14();
            Tehtävä15 t15 = new Tehtävä15();
            Tehtävä16 t16 = new Tehtävä16();
            Tehtävät17 t17 = new Tehtävät17();
            while (Start)
            {
                Console.Clear();
                Console.Write("Valitse Tehtävä numeroina: ");
                try
                {
                    num = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    continue;
                }
                switch (num)
                {
                    case 1:
                        Console.Clear();
                        t1.tehtävä1();
                        break;
                    case 2:
                        Console.Clear();
                        t2.tehtävä2();
                        break;
                    case 5:
                        Console.Clear();
                        t5.tehtävä5();
                        break;

                    case 10:
                        Console.Clear();
                        t10.tehtävä10();
                        break;

                    case 11:
                        Console.Clear();
                        t11.tehtävä11();
                        break;
                    case 12:
                        Console.Clear();
                        t12.tehtävä12();
                        break;
                    case 13:
                        Console.Clear();
                        t13.tehtävä13();
                        break;
                    case 14:
                        Console.Clear();
                        t14.tehtävä14();
                        break;
                    case 15:
                        Console.Clear();
                        t15.tehtävä15();
                        break;
                    case 16:
                        Console.Clear();
                        t16.tehtävä16();
                        break;
                    case 17:
                        Console.Clear();
                        t17.tehtävät17();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("That's not a correct work number.");
                        Console.ReadLine();
                        break;
                }
            }
            

        }

    }
}
