using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("Enter size of array");
            N = int.Parse(Console.ReadLine());
            int[] A = new int[N];
            Random rand = new Random();
            int first = 0;
            int last = 0;
            for (int i = 0; i < N; i++)
            {
                A[i] = rand.Next(100);
                Console.Write(A[i]+" ");
            }
            Console.WriteLine();
            for (int i = 0; i < N; i++)
            {
                if (A[0] < A[i] & A[i] < A[N - 1])
                {
                    first = A[i];break;
                }
            }
            for (int i = 0; i < N; i++)
            {
                if (A[0] < A[i] & A[i] < A[N - 1])
                {
                    last = A[i];
                }
            }
            Console.WriteLine("First number in a row =" + first);
            Console.WriteLine("last number in a row =" + last);
        }
    }
}
