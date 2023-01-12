using System;

namespace BasicProblem0504
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("첫 번째 숫자를 입력하세요.");
            double number1 = double.Parse(Console.ReadLine());
            Console.WriteLine("두 번째 숫자를 입력하세요.");
            double number2 = double.Parse(Console.ReadLine());

            Console.WriteLine(number1 + number2);
            Console.WriteLine(number1 - number2);
            Console.WriteLine(number1 * number2);
            Console.WriteLine(number1 / number2);
        }
    }
}
