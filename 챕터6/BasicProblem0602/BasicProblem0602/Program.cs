using System;

namespace BasicProblem0602
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("먹은 사과 개수를 입력하세요.");
            int eatenAppleCount = int.Parse(Console.ReadLine());
            if (eatenAppleCount > 3)
            {
                Console.WriteLine("사과를 많이 먹었습니다.");
            }
            else if(eatenAppleCount < 3)
            {
                Console.WriteLine("사과를 조금 먹었습니다.");
            }
            else
            {
                Console.WriteLine("사과를 적절히 먹었습니다.");
            }
        }
    }
}
