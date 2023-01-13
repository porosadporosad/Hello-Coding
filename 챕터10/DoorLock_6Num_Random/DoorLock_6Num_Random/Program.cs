using System;

namespace DoorLock_6Num_Random
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int passCodeLength = 6;

            int[] passcodeNumbers = new int[passCodeLength];

            Console.WriteLine("비밀번호: ");
            for (int i=0; i<passCodeLength;i++)
            {
                passcodeNumbers[i] = random.Next(0, 10);
                Console.Write(passcodeNumbers[i]);
                Console.WriteLine(" ");
            }

            int[] userInput = new int[passCodeLength];


            while (true)
            {
                for (int userInputNumber = 0; userInputNumber < passCodeLength; userInputNumber++)
                {
                    Console.Write(userInputNumber);
                    Console.WriteLine(" 번째 숫자를 넣어주세요.");
                    userInput[userInputNumber] = int.Parse(Console.ReadLine());
                }
                bool correctPassword = true;
                for (int userInputNumber = 0; userInputNumber < passCodeLength; userInputNumber++)
                {
                    if (passcodeNumbers[userInputNumber] != userInput[userInputNumber])
                    {
                        correctPassword = false;
                        Console.WriteLine("비밀번호가 틀렸습니다.");
                        break;
                    }
                }
                if (correctPassword)
                {
                    Console.WriteLine("문이 열렸습니다.");
                    break;
                }

            }
        }
    }
}