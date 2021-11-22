using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вычесление радиуса  и площади круга
            double a = Math.PI;
            double secondNumbe;
            secondNumbe = 30;
            double radius = secondNumbe / (2 * a);
            double areaCirele = a * (radius * radius);
            Console.WriteLine("Радиус=");
        Console.WriteLine(radius);
            Console.WriteLine("Периметр=");
            Console.WriteLine(areaCirele);
            Console.ReadKey();
        }
    }
}
