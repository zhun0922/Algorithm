using System;
using System.Diagnostics;
using static System.Console;

namespace Baekjoon
{
    class BJ25304
    {
     static void Main(string[] args)
        {
            int totalPrice = int.Parse(ReadLine());
            int n = int.Parse(ReadLine());
            int comparePrice = 0;

            for(int i = 1; i<= n; i++)
            {
                string[] s = ReadLine().Split();
                int a = int.Parse(s[0]);
                int b = int.Parse(s[1]);

                comparePrice += a * b;

            }

            if (totalPrice == comparePrice) WriteLine("Yes");
            else WriteLine("No");
        }
    }
}