using System;

namespace BasicProblem1004
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1~100까지 숫자를 맞추세요!");
            Random random = new Random();
            int MainNumber = random.Next(1, 101);
                       
            while(true)
            {
                Console.WriteLine("1~100까지의 숫자를 고르세요!");
                int PlayerNumber = int.Parse(Console.ReadLine());

                if (MainNumber == PlayerNumber)
                {
                    Console.WriteLine("정답!");
                    break;
                    
                } else if (PlayerNumber < 1 || PlayerNumber > 100)
                {
                    Console.WriteLine("NO!");
                } else if(MainNumber < PlayerNumber)
                {
                    Console.WriteLine("커요.");

                } else if(MainNumber > PlayerNumber)
                {
                    Console.WriteLine("작아요.");
                } 
            }

        }
    }
}
