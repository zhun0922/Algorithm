using System;
using static System.Console;

namespace Baekjoon
{
    class BJ2753_2
    {
        static void Main(string[] args)
        {
            int year = Convert.ToInt32(ReadLine());

           // 문제조건 어긋날 경우 return으로 현재 메소드 종결
            if (year < 1 || year > 4000) return;  
      
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                WriteLine(1);
            else
                WriteLine(0);
                
        }
    }
}