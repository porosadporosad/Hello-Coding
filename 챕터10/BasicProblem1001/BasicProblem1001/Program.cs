using System;

namespace BasicProblem1001
{
    class Program
    {
        static void Main(string[] args)
        {
            int LottoLength = 6;

            int[] LottoNumber = new int[LottoLength];
            

            int i = 0;
            while (i < LottoLength)
            {
                Random random = new Random();
                int Number = random.Next(5, 60);
                LottoNumber[i] = Number;

                bool NumberTrue = false;
                for (int j = 0; j < i; j++)
                {
                    if (LottoNumber[i] == LottoNumber[j])
                    {
                        NumberTrue = true;
                        break;
                    }
                }

                if (!NumberTrue)
                {
                    i++;
                }
            }

            for(int j =0; j< LottoLength; j++)
            {
                Console.Write(LottoNumber[j]);
                Console.Write("번, ");               
            }
            
        } 
    }
}