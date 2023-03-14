// EOF에 대해 알아보는 문제

// : End Of File

// 간단하게 파일의 끝을 확인할 수 있는가를 묻는다

 

// 아래 코드처럼 간략하게 if문으로 input에 입력값이 없어 null상태가 되면 무한루프를 빠져나갈 수 있게 한다는데

// EOF가정확히뭔지.. 저걸로 eof구현끝?

using System;
using System.Diagnostics;
using static System.Console;

namespace Baekjoon
{
    class BJ10951
    {
       static void Main()
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (input == null) break;
            string[] AB = input.Split();
            int a = int.Parse(AB[0]);
            int b = int.Parse(AB[1]);
            Console.WriteLine(a + b);
        }
    }
    }
}