using System;
using System.Diagnostics;
using static System.Console;

namespace Baekjoon
{
    class BJ8393
    {
      static void Main(string[] args)
        {
            int input = Convert.ToInt32(ReadLine());
            int sum = 0;
           for (int i =1; i<=input; i++)
            {
                sum += i;        
            }
            WriteLine(sum);
        }
    }
}