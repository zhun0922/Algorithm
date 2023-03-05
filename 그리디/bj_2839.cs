using System;
using System.Diagnostics;
using static System.Console;

namespace Baekjoon
{
    class BJ2839
    {
        static void Main(string[] args)
        {
            int kg = int.Parse(ReadLine());
            int result=0;

            while (kg > 0)
            {
                if (kg % 5 == 0)
                {
                    result += kg / 5;
                    break;
                }
                else
                {
                    kg -= 3;
                    result++;
                }
            }

            if (kg < 0)
                WriteLine(result = -1);
            else
            WriteLine(result);
                
        }
    }
}