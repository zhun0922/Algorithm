using System;
using System.Diagnostics;
using static System.Console;

namespace Baekjoon
{
    class BJ2438
    {
     static void Main(string[] args)
        {
            int num = int.Parse(ReadLine());

            for(int i = 1; i<=num; i++)
            {
                for(int j =1; j<=i; j++)
                {
                    Write("*");
                }
                WriteLine();
            }   
        }
    }
}