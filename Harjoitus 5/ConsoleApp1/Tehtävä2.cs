using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarjousTehtävä
{
    class Tehtävä2
    {

        public void tehtävä2()
        {
            string Celsius = "°C";
            string Fahren = "°F";
            int CelsiusNum = 0;
            double FahrenNum = 0;

            Console.Write("Write down your Celsius Number: ");
            CelsiusNum = int.Parse(Console.ReadLine());
            FahrenNum = Change(CelsiusNum);
            Console.Write(CelsiusNum + Celsius + " Was changed to " + FahrenNum + Fahren);
            Console.Read();
        }


        static double Change(int CelsiusNum)
        {
            double FahrenNum;
            FahrenNum = CelsiusNum * 1.8 + 32; //formula
            return FahrenNum;
        }



    }
}
