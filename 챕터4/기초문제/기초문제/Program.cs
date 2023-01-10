using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(10 + 5);
            Console.WriteLine(20 - 10);
            Console.WriteLine(4 * 7);
            Console.WriteLine("몫 : " + 20 / 7 + " 나머지 : " + 20 % 7);

            Console.WriteLine("안녕" + "하세요");

            int number1 = 20;
            int number2 = 5;
            int number3 = 3;
            int number4 = 13;
            int number5;

            number1 = number1 + number2;
            number2 = number3 + number4;
            number4 = number1 - number4;
            number3 = number2 / number4;
            number5 = number2 % number4;

            Console.WriteLine(number1);
            Console.WriteLine(number2);
            Console.WriteLine(number3);
            Console.WriteLine(number4);
            Console.WriteLine(number5);

            int number6 = 4 - 2;
            number6 = number6 * 16;
            number6 = number6 + 2;

            Console.WriteLine("(4 - 2) * 16 + 2");
            Console.WriteLine(number6);

            int number = 2;
            number = number * 3;
            number = number - 4;
            number = number % 2;

            Console.WriteLine(number);

            int coin = 10;

            int a1 = coin / 2 - 1;

            int a2 = (coin - a1) / 2 + 2;
            coin = coin - a1 - a2;

            Console.WriteLine("코인 : " + coin);
            Console.WriteLine("아람 : " + a1);
            Console.WriteLine("우람 : " + a2);
        }
    }
}