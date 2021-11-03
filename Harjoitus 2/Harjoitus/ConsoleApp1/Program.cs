using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool tt = true;
            long a = 0;

            while (tt)
            {
                Random rnd = new Random();
                a = rnd.Next(-1000000000, 999999999);
                Console.WriteLine(a);
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
