using System;
using static System.Console;

namespace Baekjoon
{
    class BJ9498
    {
      static void Main(string[] args)
        {
            int score = int.Parse(ReadLine());

            if (score >= 90)
                WriteLine("A");
            else if (score >= 80)
                WriteLine("B");
            else if (score >= 70)
                WriteLine("C");
            else if (score >= 60)
                WriteLine("D");
            else
                WriteLine("F");
        }
    }
}
