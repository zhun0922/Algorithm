// 2. switch문 사용 + Math.Truncate() 로 소수점 날리는 방법 사용


// Math.Truncate

 

// decimal Math.Truncate(decimal d)
// double Math.Truncate(double d) //참고로 이렇게 뜰 때도 있다
 

// visual스튜디오에 이렇게 뜸

// 그러면 매개변수로 당연히 소수점 decimal형식을 넣어줘야한다

// 이 코드에서 만약 input/10.0을 안하고 정수 input을 매개변수로 넣어주면 오류

 

// 그리고 decimal형식을 int score 에 넣기 때문에 (int)형변환 필요

using System;
using static System.Console;

namespace Baekjoon
{
    class BJ9498_2
    {
      static void Main(string[] args)
        {
            int input = Convert.ToInt32(ReadLine());
            int score = (int)(Math.Truncate(input / 10.0) * 10);
            //Truncate- 소수점 날리기
            //Truncate는 declimal형식이므로 매개변수에 나누기 10을해서 decimal 형식으로 만들어야하고
            //decimal이기 때문에 (int) - int로 형변환
            
            string grade = "";

            switch (score)
            {
                case 100: //
                case 90: //조건 두개에 같은 출력
                    grade = "A";
                    break;
                case 80:
                    grade = "B";
                    break;
                case 70:
                    grade = "C";
                    break;
                case 60:
                    grade = "D";
                    break;
                default:
                    grade = "F";
                    break;
            }
            WriteLine(grade);


        }
    }
}

