//?: 사용

using System;
using System.Diagnostics;
using static System.Console;

namespace Baekjoon
{
    class BJ2839_2
    {
        static void Main(string[] args)
        {
           int kg = int.Parse(ReadLine());
            int result=0;

            while(kg % 5 != 0 && kg > 0)
            {
                kg -= 3;
                result++;
            }
            Console.WriteLine(kg >= 0 ? result + kg / 5 : -1);
                
        }
    }
}