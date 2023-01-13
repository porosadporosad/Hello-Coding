using System;

namespace DoorLock_6Num_For
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] passcodeNumbers = { 1, 5, 5, 7, 1, 6 };

            int passCodeLength = 6;
            int[] userInput = new int[passCodeLength];


            while (true)
            {
                for(int passCodeIndex =0; passCodeIndex < passCodeLength; passCodeIndex++)
                {
                    Console.Write(passCodeIndex);
                    Console.WriteLine(" 번째 숫자를 넣어주세요.");
                    userInput[passCodeIndex] = int.Parse(Console.ReadLine());                  
                }
                bool isPassWordCorrect = true;
                for (int passCodeIndex = 0; passCodeIndex < passCodeLength; passCodeIndex++)
                {
                    if(passcodeNumbers[passCodeIndex] != userInput[passCodeIndex])
                    {
                        isPassWordCorrect = false;
                        Console.WriteLine("비밀번호가 틀렸습니다.");
                        break;
                    }
                }
                if (isPassWordCorrect)
                {
                    Console.WriteLine("문이 열렸습니다.");
                    break;
                }
                
            }
        }
    }
}