using System;

namespace BasicProblem0503
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("첫 번째 숫자를 입력하세요.");
            double number = double.Parse(Console.ReadLine());
            Console.Write("입력한 숫자는  ");
            Console.WriteLine(number);
        }
    }
}

