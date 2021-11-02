using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("KIrjoita luku: ");
            int luku1;
            luku1 = int.Parse(Console.ReadLine());
            int luku2;
            Console.Write("Kirjoita toinen luku: ");
            luku2 = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("x = " + luku1 + 3);
            Console.ReadLine();

            Console.Write("KIrjoita luku: ");
            luku1 = int.Parse(Console.ReadLine());
            Console.Write("Kirjoita toinen luku: ");
            luku2 = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("x = {0}", luku1 - 2);
            Console.ReadLine();


            Console.Write("KIrjoita luku: ");
            luku1 = int.Parse(Console.ReadLine());
            Console.Write("Kirjoita toinen luku: ");
            luku2 = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("x = {1}", luku1 - 2);
            Console.ReadLine();

            Console.Write("KIrjoita luku: ");
            luku1 = int.Parse(Console.ReadLine());
            Console.Write("Kirjoita toinen luku: ");
            luku2 = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("x = {1}", luku1 - 2);
            Console.ReadLine();








        }
    }
}
