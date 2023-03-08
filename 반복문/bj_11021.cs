using System;
using System.Diagnostics;
using static System.Console;

namespace Baekjoon
{
    class BJ11021
    {
     static void Main(string[] args)
        {
            int count = int.Parse(ReadLine());

            for (int i = 1; i <= count; i++)
            {
                string[] s = ReadLine().Split();
                int a = Convert.ToInt32(s[0]);
                int b = Convert.ToInt32(s[1]);

                WriteLine("Case #{0}: {1}", i, a + b);
            }    
        }
    }
}