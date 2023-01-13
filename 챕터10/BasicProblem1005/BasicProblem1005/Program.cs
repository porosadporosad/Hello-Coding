using System;

namespace BasicProblem1005
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("가위바위보");
            Console.WriteLine();
            Console.WriteLine("가위 = 1, 바위 = 2, 보 = 3 입니다.");
                        
            bool NumberTrue = true;
            while(NumberTrue)
            {
                Random random = new Random();
                int ComNumber = random.Next(1, 4);

                Console.WriteLine("당신의 숫자는??");
                int PlayerNumber = int.Parse(Console.ReadLine());

                if (PlayerNumber ==ComNumber)
                {
                    Console.WriteLine("비겼어요!");
                }
                else if (PlayerNumber < 1 || PlayerNumber > 3)
                {
                    Console.WriteLine("1~3에서 골라주세요..");
                }
                else if (ComNumber == 1)
                {                   
                        if(PlayerNumber == 2)
                        {
                            Console.WriteLine("졌어요..");
                            break;
                        }
                        else
                        {                           
                            Console.WriteLine("이겼어요!!");
                            break;
                        }                   
                } else if (ComNumber == 2)
                {
                    
                        if (PlayerNumber == 1)
                        {
                            Console.WriteLine("졌어요..");
                            break;
                        }
                        else
                        {                          
                            Console.WriteLine("이겼어요!!");
                            break;
                        }                   
                } else if (ComNumber == 3)
                {                   
                        if (PlayerNumber == 2)
                        {
                            Console.WriteLine("졌어요..");
                            break;
                        }
                        else
                        {                           
                            Console.WriteLine("이겼어요!!");
                            break;
                        }                   
                }              
            }
        }
    }
}