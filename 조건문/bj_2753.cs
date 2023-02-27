using System;
using static System.Console;

namespace Baekjoon
{
    class BJ2753
    {
        static void Main(string[] args)
        {
            int year = Convert.ToInt32(ReadLine());
            if (year % 4 == 0)
            {
                if ((year % 100 != 0) || (year % 400 == 0))
                {
                   WriteLine(1);
                }
                else //이거 안써서 틀림
                    WriteLine(0); 
            }
            else
                WriteLine(0);
        }
    }
}