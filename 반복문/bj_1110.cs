using System;
using System.Diagnostics;
using static System.Console;

namespace Baekjoon
{
    class BJ1110
    {
       static void Main(string[] args)
        {

            int input = int.Parse(ReadLine());
            int copyInput = input;
      
            int count = 0; 

            while (true)
            {
                count += 1;
                
                int a = copyInput / 10;
                int b = copyInput % 10;
                
                int sum = a + b;
                
                copyInput = b * 10 + sum % 10; 
 
                if(input == copyInput)
                {
                    break;
                }            
            }

            WriteLine(count);         
        }
    }
}