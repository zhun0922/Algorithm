// 2. 다른사람코드

// for문에서 형변환 수행

// n과 x를 일일이 새로운 변수에 넣지않고 s[0], s[1]로 써서 코드자체는 짧긴한데.. 난 일단 지금은 내가 한 것 처럼 새로운 변수에 넣는게 좋다고 생각한다

using System;
using System.Diagnostics;
using static System.Console;
using System.Text;

namespace Baekjoon
{
    class BJ10871_2
    {
        static void Main(string[] args)
        {
        	// s[0]은 수열의 A, s[1]은 정수 X
            string[] s = ReadLine().Split();
            // s[0]을 이루는 수열들
            string[] q = ReadLine().Split();

            StringBuilder answer = new StringBuilder();

            for (int i = 0; i < int.Parse(s[0]); i++)
            {
                // 정수 x보다 작은 숫자들을 검출
                if (int.Parse(s[1]) > int.Parse(q[i]))
                {
                	// 해당 숫자들을 answer에 공백과 함께 추가한다.
                    answer.Append(q[i] + " ");
                }
            }
            // 정답 출력
            WriteLine(answer.ToString());
        }                        
    }
}