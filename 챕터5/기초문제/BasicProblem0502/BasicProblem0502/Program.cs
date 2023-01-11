using System;

namespace BasicProblem0502
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("첫 번째 숫자를 입력하세요.");
            string userInput1 = Console.ReadLine();
            Console.WriteLine("두 번째 숫자를 입력하세요.");
            string userInput2 = Console.ReadLine();
            int number1 = int.Parse(userInput1);
            int number2 = int.Parse(userInput2);

            
            Console.WriteLine(number1 - number2);
        }
    }
}