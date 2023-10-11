using System.Reflection.Metadata;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args) {
            // 0:가위 1:바위 2:보
            const int ROCK = 1;
            const int PAPER = 2;
            const int SCISSORS = 0;
            Random rand = new Random();
            int aiChoice = rand.Next(0,3);
            bool isOk = false;
            int choice = -1;
            while(!isOk){
                Console.WriteLine("0:가위 1:바위 2:보 골라주세요!");
                choice = Convert.ToInt32(Console.ReadLine());
                if(choice == 0 || choice == ROCK || choice == PAPER) isOk = true;
            }
            

            switch (choice){
                case SCISSORS:
                    Console.WriteLine("당신의 선택은 가위입니다.");
                    break;
                case ROCK:
                    Console.WriteLine("당신의 선택은 바위입니다.");
                    break;
                case PAPER:
                    Console.WriteLine("당신의 선택은 보입니다.");
                    break;
            }

            switch (aiChoice){
                case SCISSORS:
                    Console.WriteLine("컴퓨터의 선택은 가위입니다.");
                    break;
                case ROCK:
                    Console.WriteLine("컴퓨터의 선택은 바위입니다.");
                    break;
                case PAPER:
                    Console.WriteLine("컴퓨터의 선택은 보입니다.");
                    break;
            }

            // 승리 무승부 패배
            if(aiChoice == choice){
                Console.WriteLine("무승부입니다.");
            }else if(aiChoice == SCISSORS){
                if(choice == ROCK){
                    Console.WriteLine("당신이 이겼습니다.");
                }else{
                    Console.WriteLine("컴퓨터가 이겼습니다.");
                }
            }else if(aiChoice == ROCK){
                if(choice == SCISSORS){
                    Console.WriteLine("컴퓨터가 이겼습니다.");
                }else{
                    Console.WriteLine("당신이 이겼습니다.");
                }
            }else{
                if(choice == SCISSORS){
                    Console.WriteLine("당신이 이겼습니다.");
                }else{
                    Console.WriteLine("컴퓨터가 이겼습니다.");
                }
            }
        }
    }
}