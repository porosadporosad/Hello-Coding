using System;

namespace UltimateBaseball
{
    class Promram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+-----------------------------------------------------+");
            Console.WriteLine("!                궁극의 숫자야구 게임                 !");
            Console.WriteLine("+-----------------------------------------------------+");
            Console.WriteLine("! 컴퓨터가 수비수가 되어 세 자릿수를 하나 골랐습니다. !");
            Console.WriteLine("! 각 숫자는 0~9중에 하나며 중복되는 숫자는 없습니다.  !");
            Console.WriteLine("! 모든 숫자와 위치를 맞추면 승리합니다.               !");
            Console.WriteLine("! 숫자와 순서가 둘 다 맞으면 스트라이크입니다.        !");
            Console.WriteLine("! 숫자만 맞고 순서가 틀리면 볼입니다.                 !");
            Console.WriteLine("! 숫자가 틀리면 아웃입니다.                           !");
            Console.WriteLine("+-----------------------------------------------------+");

            Console.WriteLine("> 수비수가 고른 숫자");
            int[] number = { 3, 1, 9 };
            Console.WriteLine(number[0]);
            Console.WriteLine(number[1]);
            Console.WriteLine(number[2]);

            int[] guess = new int[3];

            while (true)
            {
            Console.WriteLine("> 첫 번째 숫자를 입력하세요.");
            guess[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("> 두 번째 숫자를 입력하세요.");
            guess[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("> 세 번째 숫자를 입력하세요.");
            guess[2] = int.Parse(Console.ReadLine());

            Console.WriteLine("> 공격수가 고른 숫자");
            Console.WriteLine(guess[0]);
            Console.WriteLine(guess[1]);
            Console.WriteLine(guess[2]);

                if (guess[0] == guess[1] || guess[0] == guess[2] || guess[1] == guess[2])
                {
                    Console.WriteLine("같은 숫자를 입력하시면 안됩니다.");
                    continue;
                }
                else
                {
                    int strikeCount = 0;
                    int ballCount = 0;

                    if (guess[0] == number[0])
                    {
                        strikeCount = strikeCount + 1;
                    }
                    else if (guess[0] == number[1] || guess[0] == number[2])
                    {
                        ballCount = ballCount + 1;
                    }

                    if (guess[1] == number[1])
                    {
                        strikeCount = strikeCount + 1;
                    }
                    else if (guess[1] == number[0] || guess[1] == number[2])
                    {
                        ballCount = ballCount + 1;
                    }

                    if (guess[2] == number[2])
                    {
                        strikeCount = strikeCount + 1;
                    }
                    else if (guess[2] == number[0] || guess[2] == number[1])
                    {
                        ballCount = ballCount + 1;
                    }

                    Console.Write("스트라이크: ");
                    Console.WriteLine(strikeCount);
                    Console.Write("볼: ");
                    Console.WriteLine(ballCount);
                    Console.Write("아웃: ");
                    Console.WriteLine(3 - strikeCount - ballCount);

                    if (guess[0] == number[0] && guess[1] == number[1] && guess[2] == number[2])
                    {
                        Console.WriteLine("정답입니다!");
                        break;
                    }
                }
            }
        }
    }
}