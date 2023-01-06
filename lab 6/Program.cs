using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata;
using System.Text;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string UserRow = Console.ReadLine();

            UserRow = ReverseDot(UserRow);
            Console.Write('.');
            UserRow = Reverse(UserRow);
        }    
        static string Reverse(string UserRow)
        {
            char[] chars = UserRow.ToCharArray();
            for (int i = UserRow.Length-1; i > 0; i--)
            {
                Console.Write(chars[i]);
                if (chars[i] == '.')
                {
                    break;
                }
            }
            return new string(chars);
        }
        static string ReverseDot(string userRow)
        {
            char[] charsdot = userRow.ToCharArray();
            for (int i = 0; i < userRow.Length-1;i++)
            {
                if (charsdot[i] == '.')
                {
                    for(int j = i-1; j+1 > 0; j--)
                    {
                        Console.Write(charsdot[j]);
                    }
                    break;
                }
            }
            return new string(charsdot);
        }
    }
}
