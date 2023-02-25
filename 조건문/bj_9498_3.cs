// 3. switch 식 사용

using System;
using static System.Console;

namespace Baekjoon
{
    class BJ9498_3
    {
        static void Main(string[] args)
        {
            int score = (int)(Math.Truncate(int.Parse(ReadLine()) / 10.0) * 10);

            string grade = score switch
            {
                100 => "A",
                90 => "A",
                80 => "B",
                70 => "C",
                60 => "D",
                _ => "F"
            };
            WriteLine(grade);        
        }
    }
}