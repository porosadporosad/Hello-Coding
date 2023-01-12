using System;

namespace BasicProblem0801
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[5];
            int i = 0;
            while (i < 5)
            {
                Console.Write(i);
                Console.WriteLine("번째 과목의 성적을 입력하세요.");
                scores[i] = int.Parse(Console.ReadLine());

                i = i + 1;
            }
            Console.Write("총점은 ");
            Console.Write(scores[0] + scores[1] + scores[2] + scores[3] + scores[4]);
            Console.WriteLine("점입니다.");
        }
    }
}
