using System;
using static System.Console;

namespace Baekjoon
{
    class BJ2525
    {
        static void Main(string[] args)
        {
            string[] input = ReadLine().Split();
            int h = int.Parse(input[0]);
            int m = int.Parse(input[1]);
          

            int time = int.Parse(ReadLine());
            int[] time_h_m = new int[2];
            time_h_m[0] = time / 60;
            time_h_m[1] = time % 60;

            h += time_h_m[0];
            m += time_h_m[1];

            if (m >= 60)
            {
                m -= 60;
                h++;          
            }
            if (h >= 24)
            {
                h -= 24;
            }

            WriteLine($"{h} {m}");    
        }
    }
}