using System;
using System.Diagnostics;
using static System.Console;

namespace Baekjoon
{
    class BJ10950
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(ReadLine());
            
            for (int i = 0; i < input; i++)
            {
                string[] s = ReadLine().Split();
                int a = int.Parse(s[0]), b = int.Parse(s[1]);
                WriteLine(a + b);
            }
        }
    }
}