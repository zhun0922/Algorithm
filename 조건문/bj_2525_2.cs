using System;
using System.Numerics;

namespace boj
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] str = Console.ReadLine().Split(' ');
            int A = int.Parse(str[0]);
            int B = int.Parse(str[1]);
            int C = int.Parse(Console.ReadLine());

            B += C;

            while (B >= 60)
            {
                A++;
                B -= 60;
            }

            if(A >= 24)
            {
                A -= 24;
            }

            Console.WriteLine(A + " " + B); 
        }
    }
}
// while문으로 

// 추가되는분을 기존 입력받은 분B에 추가하고

// B가 60을넘길때마다 ..

// 만약 130분이 추가되어서 

// B-=60을해도 B>=60이기때문에

// 60미만이 나올때까지 반복