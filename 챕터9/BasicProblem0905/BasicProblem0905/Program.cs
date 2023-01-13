using System;

namespace BasicProblem0905
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] class3 = new int[5];
            


            for(int i=0;i<5;i++)
            {
                Console.Write(i+1);
                Console.WriteLine("반 ");

                
                for (int j=0; j<10;j++)
                {
                    Console.Write(j+1);
                    Console.WriteLine("번째 학생의 성적 입력하세요.");
                    int k = int.Parse(Console.ReadLine());
                    class3[i] = class3[i] + k;                    
                }             
            }

            Console.WriteLine("---------------------------------------------------------");

            for (int i = 0; i < 5; i++)
            {
                Console.Write(i+1);
                Console.WriteLine("반 ");
                Console.Write("평균 : ");
                Console.WriteLine(class3[i] / 10);
            }
        }
    }
}