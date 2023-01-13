using System;

namespace BasicProblem0904
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] passCodeNumber = { 1, 5, 5, 5, 7 };
            int[] passWord = new int[5];

            for (int i=0;i<5;i++)
            {
                for (int Number = 0; Number < 5; Number++)
                {
                    Console.Write(Number);
                    Console.WriteLine("번째 비밀번호를 입력하세요.");
                    passWord[Number] = int.Parse(Console.ReadLine());
                }

                bool pass = true;
                for (int Number = 0; Number < 5; Number++)
                {
                    if (passCodeNumber[Number] != passWord[Number])
                    {
                        pass = false;
                        Console.WriteLine("비밀번호가 틀립니다.");
                        break;
                    }                   
                }
                if (pass)
                {
                    Console.WriteLine("문이 열렸습니다.");
                    break;
                }
            }
            Console.WriteLine("비밀번호를 5번 틀렸습니다.");
        }
    }
}