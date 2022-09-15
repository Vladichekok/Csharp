using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;
            Console.WriteLine("Введiть х");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введiть y");
            y = double.Parse(Console.ReadLine());
            if (x >= 0 & y >=0 | x <=0 & y<=0)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
