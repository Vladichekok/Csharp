using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nn;
            int nk;
            int k;
            double res = 0;
            nn = int.Parse(Console.ReadLine());
            nk = int.Parse(Console.ReadLine());

            for (k = nn;  k<nk; k++)
            {
                if (0 <= nn & nn <= nk)
                {
                    res += (Math.Pow(k, 2) - (Math.Pow(-1, k + 1) * (Math.Pow(k, 3)))) / ((Math.Pow(k, 2)) + k + 1);
                }
                else
                {
                    Console.WriteLine("error");
                    return;
                }
            }
            Console.WriteLine(res);
        }
    }
}
