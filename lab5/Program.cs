using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n,m;
            Console.WriteLine("Enter n");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter m");
            m = int.Parse(Console.ReadLine());
            Random rand = new Random();
            int[,] arr = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = rand.Next(20);
                    Console.Write(arr[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int tempmax = int.MinValue;
            int tempmin = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                
                for (int j = 0; j < m; j++)
                {
                    if (arr[i, j] > tempmax)
                    { 
                        tempmax = arr[i, j];
                    }
                }
                Console.WriteLine("vertikal max = " + tempmax);
                tempmax = 0;
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (arr[j, i] > tempmax)
                    {
                        tempmax = arr[j ,i ];
                    }
                }
                Console.WriteLine("horizontal max = " + tempmax);
                tempmax = 0;
            }
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < m ; j++)
                {
                    if (arr[i, j] < tempmin)
                    {
                        tempmin = arr[i, j];
                    }
                }
                Console.WriteLine("vertikal min = " + tempmin);
                tempmin = int.MaxValue;
            }
            for (int i = 0; i < m; i++)
            {

                for (int j = 0; j < n; j++)
                {
                    if (arr[j, i] < tempmin)
                    {
                        tempmin = arr[j, i];
                    }
                }
                Console.WriteLine("horizontal min = " + tempmin);
                tempmin = int.MaxValue;
            }
        }
    }
}
