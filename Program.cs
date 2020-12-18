using System;
using System.Runtime.CompilerServices;

namespace Ханойский_башни
{
    class Program
    {
        static void move(int n, int i, int j, int k)
        {
            if (n == 1) 
            {
                Console.WriteLine($"{n} {i} {j}"); 
            }
            else
            {
                move(n - 1, i, k, j);
                Console.WriteLine($"{n} {i} {j}");
                move(n - 1, k, j, i);
            }
           
        }
        static void Main(string[] args)
        {
            move(4, 1, 3, 2);
        }
    }
}
