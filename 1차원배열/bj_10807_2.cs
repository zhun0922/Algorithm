// System.Array
// 해당조건을 만족하는 번호 반환, 없으면 -1
// System.Array.FindIndex(배열, x => x.name == "A");

// // 해당조건을 만족하는 첫번째 값 반환
// System.Array.Find(배열, x => x.name == "A");

// // 해당조건을 만족하는 모든 값 리스트로 반환
// System.Array.FindAll(배열, x => x.name == "A");

// // 중복만 추출
// var redundantArray = System.Array.FindAll(배열, x => List.Contains(x));

// // RemoveAll 용도
// System.Array.FindAll(배열, x => x.name != "A");

// // 해당조건을 만족하는 요소가 한 개라도 존재하는지 검사
// System.Array.Exists(배열, x => x.name = "A");

// // 내용물에 전부 1 더해 반환
// int[] 배열 = System.Array.ConvertAll(배열, x => x+1);

// // 0으로 초기화
// int[] 배열 = System.Array.ConvertAll(배열, x => 0);

// // true 검사
// System.Array.Find(배열, x => x == true);

// // true 검사2
// System.Array.TrueForAll(배열, x => x.isOn == false);

// // 포함 여부 검사
// if (System.Array.TrueForAll(배열, x => List.Contains(x));

using System;
using System.Diagnostics;
using static System.Console;

namespace Baekjoon
{
    class BJ10807_2
    {
        static void Main(string[] args)
        {
            // 정수의 개수
            int n = int.Parse(Console.ReadLine());  

            // 정수 배열
            string [] numbers = Console.ReadLine().Split();

            // 찾으려는 정수
            string v = Console.ReadLine();


			//위의 foreach문이 Array.FindAll로 한줄로 정리됨
            // 찾기
            int result = Array.FindAll(numbers, x => x == v).Length;

            Console.WriteLine(result);
        }
    }
}