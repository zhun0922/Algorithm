// 1. 내가 푼 코드 

// 문제점 :

// 굳이 int로 형변환해서 string[]배열을 int[] 로 만드는과정추가됨

// System.Array라이브러리 함수몰라서 foreach문으로  타겟갚과 맞는지 판별 

 

// 참고로 만약 배열을 형변환 할거면

// 여기서 for문으로 배열 형변환하면서 복사했는데

// 이렇게 말고

// Array.ConvortAll( 변환할 배열, 변환할 형식 ) 사용!
// string[] stringNumber = Console.ReadLine().Split();
// int[] number = Array.ConvertAll(stringNumber, int.Parse);

using System;
using System.Diagnostics;
using static System.Console;

namespace Baekjoon
{
    class BJ10807
    {
        static void Main(string[] args)
        {
            int n = int.Parse(ReadLine());
            int[] number = new int[n];
            
            string[] s = new string[n];
              s=  ReadLine().Split();

            int target = int.Parse(ReadLine());

            for (int i = 0; i<n; i++)
            {
                number[i] = int.Parse(s[i]);
            }

            int count = 0;
            foreach (int i in number)
            {
                if ( i == target)
                {
                    count++;
                }
            }
            WriteLine(count);                     
        }
                
        
    }
}