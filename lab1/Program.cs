using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double R;
            double I;
            double U;
            Console.WriteLine("Введiть силу струму");
            I = double.Parse(Console.ReadLine());
            Console.WriteLine("Введiть напругу");
            U = double.Parse(Console.ReadLine());
            if (U > 0)
            { 
                Console.WriteLine("емпiрична формула справедлива для будь - якої дiлянки ланцюга: R=I/U");
            
                R = I / U;
                Console.WriteLine(R);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
