// for {    ............①

//         for {}  .....② 

//              +

//         for {}  .....③

//       }
using System;
using static System.Console;

namespace Baekjoon
{
    class BJ2439
    {
        static void Main(string[] args)
        {
            int num = int.Parse(ReadLine());
            string s = " ";
           for(int i = 1; i<=num; i++)
            {
                for(int k = num-1; k>=i; k--)
                {
                    Write(" ");                      
                }
                for (int j = 1; j <= i; j++)
                {
                    Write("*");
                }
                WriteLine();
            }
        }
    }
}