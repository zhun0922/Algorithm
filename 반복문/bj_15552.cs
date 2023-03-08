using System;
// StringBuilder를 사용하기 위해서.
using System.Text;

namespace for문4
{
    class BJ15552
    {
        static void Main(string[] args)
        {
            // 스트링빌더 answer 선언
            StringBuilder answer = new StringBuilder();

            // 테스트케이스 개수 입력 받음
            int t = int.Parse(Console.ReadLine());
            
            // 더하기 때 사용할 int를 배열로 생성함
            int[] a = new int[t];
            int[] b = new int[t];

            for (int i = 0; i < t; i++)
            {
                // 숫자를 입력받고 공백을 기준으로 나눠 담을 수 있게 문자열 배열을 선언한다.
                string[] s = Console.ReadLine().Split();
                // 입력받은 문자를 int형으로 변환해서 저장한다.
                a[i] = int.Parse(s[0]);
                b[i] = int.Parse(s[1]);
                
                // 각 숫자를 더한뒤 문자열로 변환하고 answer에 집어 넣음
                answer.AppendLine((a[i] + b[i]).ToString());
            }
            // 출력
            Console.WriteLine(answer.ToString());
        }
    }
}

//StringBuilder를 사용할수 있는가?
// => 반복적으로 Console.WriteLine()을 사용할 경우 고려 

// => string을 많이 쓰게 될 경우 고려

// Console.WriteLine()만 사용하는 대신 반복되는 출력을 1초안에 할 수 있냐는 성는문제인데

// 기존의 방식대로 string을 사용해서 출력을 하게되면

// 무조건 시간초과가 발생하는 문제이다.

 

// string은 사용하면 할수록 처리 속도가 느려지게 된다.

// 이유를 설명하려면 다소 복잡한데...

 

// 약간 간략하게 압축해서 설명하자면,

// int나 float는 값형식인 것에 비해서, string 형식은 참조형식이다.

 

// 또한, string 변수를 변형하거나 바꾸는 등의 작업을 수행하면

// 저장되었던 값이 바뀌는 것이 아니라

// 새로운 저장공간에 새로운 string이 생성되는 방식이다.

 

// 그러다보니 string을 많이쓰면 쓸수록 공간이 낭비되고 속도가 느려진다.

 

// c#에서는 이를 방지하기 위해 StringBuilder라는 것이 존재한다.

// 먼저, StringBuilder를 사용하려면

// using System.Text; 를 적어줘야만 한다.

 

// 스트링빌더에 대해서 간단히 설명하면

// 문자열을 한번에 통합적으로 관리한다고 생각하면 된다.

// Append()  : 줄바꿈 x (WriteLine)

// AppendLine()  : 줄바꿈 (WriteLine())

// 메소드를 사용해서 문자열을 담아둘 수 있다.

// 출력할 때는 ToString()으로 뽑아낸다.

 

// 그리고 아직 배열문제에 진입하지는 않았지만,

// 효과적으로 문제를 풀기위해서 어쩔 수 없이 배열을 사용했다.
