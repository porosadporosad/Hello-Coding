using System;

namespace DoorLock_6Num
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] passcodeNumbers = { 6, 2, 1, 9, 4, 7 };
            int[] userInput = new int[6];
            

            while (true)
            {
                int i = 0;
                while (i < 6)
                {
                    Console.Write(i);
                    Console.WriteLine(" 번째 숫자를 넣어주세요.");
                    userInput[i] = int.Parse(Console.ReadLine());                  

                    i = i + 1;
                }

                if (passcodeNumbers[0] == userInput[0] && passcodeNumbers[1] == userInput[1]
                    && passcodeNumbers[2] == userInput[2] && passcodeNumbers[3] == userInput[3]
                    && passcodeNumbers[4] == userInput[4] && passcodeNumbers[5] == userInput[5])
                {
                    Console.WriteLine("문이 열렸습니다.");
                    break;
                }
                else
                {
                    Console.WriteLine("비밀번호가 틀렸습니다.");
                    
                }
            }
        }
    }
}