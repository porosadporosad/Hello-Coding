using System;

namespace BasicProblem0706
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] score = new double[5];
          
            Console.WriteLine("국어 점수를 입력하세요.");
            score[0] = double.Parse(Console.ReadLine());
            
            Console.WriteLine("영어 점수를 입력하세요.");
            score[1] = double.Parse(Console.ReadLine());
           
            Console.WriteLine("수학 점수를 입력하세요.");
            score[2] = double.Parse(Console.ReadLine());
            
            Console.WriteLine("과학 점수를 입력하세요.");
            score[3] = double.Parse(Console.ReadLine());
            
            Console.WriteLine("사회 점수를 입력하세요.");
            score[4] = double.Parse(Console.ReadLine());
            
            Console.Write("총점 : ");
            Console.WriteLine(score[0] + score[1] + score[2] + score[3] + score[4]);
            Console.Write("평균 : ");
            Console.WriteLine((score[0] + score[1] + score[2] + score[3] + score[4])/5);
        }
    }
}