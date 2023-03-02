using System;
using static System.Console;

namespace Baekjoon
{
    class BJ2884
    {
        static void Main(string[] args)
        {
            string[] s = ReadLine().Split();
            int h = int.Parse(s[0]);
            int m = int.Parse(s[1]);
            if (h < 0 || h > 23 || m < 0 || m > 59) return;
       
            m -= 45;
            if (m < 0)
            {
                h -= 1;
                //h -- 로 썼으면 더 좋았을텐데
                m += 60; 
            }

            if (h < 0)
            {
                h += 24;
            }
            WriteLine($"{h} {m}");
           
            
        }
    }
}