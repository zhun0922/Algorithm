using System;
using static System.Console;

namespace Baekjoon
{
    class MainApp
    {

        static void Main(string[] args)
        {
            string s = ReadLine();
            string b = ReadLine();
            char[] c = b.ToCharArray();

            int first_num = int.Parse(s);
            int[] Second_numArray = new int[c.Length];
            for (int i = 0; i < Second_numArray.Length; i++)
            {
                Second_numArray[i] = int.Parse(c[i].ToString());
            }

            WriteLine(first_num * Second_numArray[Second_numArray.Length - 1]);
            WriteLine(first_num * Second_numArray[Second_numArray.Length - 2]);
            WriteLine(first_num * Second_numArray[Second_numArray.Length - 3]);
            WriteLine(first_num * int.Parse(b));
        }
    }
}
// Char(문자) -> int로 형변환 : 아스키 코드로 반환
// String(문자열) -> int로 형변환 : int로 반환 
// 그러면 Char형식을 string처럼 정상적인 정수로 출력하려면??

 

// 단순하게 Char형식 변수를 int.Parse()로 형변환 하면 되겠지 싶지만 

// 위에서 언급한 것 처럼 Char을 int로 형변환하면 아스키 코드로 반환된다.

 

 

// 자세히 ↓

 

// char형식을 int로 형변환 하면 아스키 코드가 반환된다

// 이 때 int.Parse()는 애초에 컴파일 오류가 나고, 

// 강제로 (int)로 형변환 시키면 아스키 코드가 반환된다

// char c = "5" 

// int i = int.Parse(c); //  오류 빨간줄 

// int i = (int) c; // 아스키 코드 53 출력 !!
// ex) 

// string s = "5" 를 int로 형변환 하면 int i = 5가 되지만,

//  char형식을 int로 강제형변환 하면, 아스키 코드가 나온다!

 

 

 

 

// 그러면 Char형식을 string처럼 정상적인 정수로 출력하는 방법은 두가지가 있다

 

//  Char형식을 아스키 코드가 아닌 정상적인 정수로 출력하는 방법
 

 

// 1.  char -> string -> int 순으로 형변환 하는 방법과, 

//  int i = int.Parse(chars[i].Tostring());
 

// 2.  Char.GetNumericeValue() -> (int) 형변환 하는 방법이 있다

// (int)Char.GetNumericValue(c);
 

// Char.GetNumericeValue()

 

// 입력을 받은 문자열은 배열형태처럼 저장되기 때문에

// [숫자] 의 형태로 해당위치의 글자를 가져올 수 있다.

 

// 또한, string은 int.Parse를 사용해서 int로 변경할 수 있었지만,

// 딱 한글자만 존재하는 Char 형식인 경우에는

// (int)Char.GetNumericValue(b[2])

// 다음과 같은 방식으로 int형태로 바꿔줄 수 있다.

// int.Parse를 암기하는 것처럼, 그냥 외우면 된다..

 