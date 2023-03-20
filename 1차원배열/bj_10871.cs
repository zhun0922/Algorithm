// 1. 푼 코드 

//  반복되는 출력이기 때문에 StringBuilder 사용해서 성능 높이고 

//  위 문제에서 배웠던 ConvertAll 형변환 적용시킴 => 한문장으로 string[] 을 int[]의 배열에 싹다형변환해서 넣어서 좋은듯

 

// 그런데 문제에서 요소의 개수를 명시적으로 입력받고 변수 n에 집어넣는데 

// foreach문에서는 변수 n을 아예 쓰지 않아

// 사용하려면 주석의 for문으로 쓰는게 맞는것 같긴하다

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
using System.Text;
using static System.Console;

namespace Baekjoon
{
    class BJ10871
    {
        static void Main(string[] args)
        {
            StringBuilder stringBuilder = new StringBuilder();
            string[] s = ReadLine().Split();
            int n = int.Parse(s[0]);
            int x = int.Parse(s[1]);

            string[] num = ReadLine().Split();
            int[] num_int = Array.ConvertAll(num, int.Parse);

            foreach(int i in num_int)
            {
                if (i < x)
                    stringBuilder.Append(i.ToString() + " ");
            }
       
            /*for(int i = 0; i<n; i++)
            {
                if (num_int[i] < x)
                    stringBuilder.Append(num_int[i].ToString() + " ");
            }
            WriteLine(stringBuilder);*/
        }
    }
}