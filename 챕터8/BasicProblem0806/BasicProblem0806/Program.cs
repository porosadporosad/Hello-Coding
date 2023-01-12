using System;

namespace BasicProblem0806
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("총학생 수를 입력하세요.");
            int studentCount = int.Parse(Console.ReadLine());

            double[] k = new double[studentCount];
            double[] e = new double[studentCount];
            double[] m = new double[studentCount];

            int studentNumber = 0;
            while ( studentNumber < studentCount)
            {
                Console.Write(studentNumber);
                Console.WriteLine("번째 학생");

                Console.WriteLine("국어 점수를 입력하세요.");
                k[studentNumber] = double.Parse(Console.ReadLine());

                Console.WriteLine("영어 점수를 입력하세요.");
                e[studentNumber] = double.Parse(Console.ReadLine());

                Console.WriteLine("수학 점수를 입력하세요.");
                m[studentNumber] = double.Parse(Console.ReadLine());

                studentNumber = studentNumber + 1;
            }

            studentNumber = 0;            

            while(studentNumber < studentCount)
            {
                double total = k[studentNumber] + e[studentNumber] + m[studentNumber];

                Console.Write(studentNumber);
                Console.WriteLine("번째 학생");
                Console.Write("총점 : ");
                Console.WriteLine(total);
                Console.Write("평균 : ");
                Console.WriteLine(total/3);

                studentNumber = studentNumber + 1;
            }
        }
    }
}