using System.Runtime.Intrinsics.X86;

namespace TextGame_SpartaDungeon
{
    //구조체만들기

    internal class Program
    {
        static void intro()
        {
            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
            Console.WriteLine("이곳에서 던전으로 들어가기 전 활동을 할 수 있습니다.");
            Console.WriteLine();

            Console.WriteLine("1. 상태보기");
            Console.WriteLine("2. 인벤토리");
            Console.WriteLine("3. 상점");
            Console.WriteLine();

            Console.WriteLine("원하시는 행동을 입력해 주세요.");
            Console.Write(">> ");
        }

        static void outText()  
        {
            Console.WriteLine("원하시는 행동을 입력해 주세요.");
            Console.Write(">> ");
        }

        static void states()
        {

        }

        static void Main(string[] args)
        {
            while (true)
            { 
                intro();
                int inputNum = int.Parse(Console.ReadLine());

                //intro반복문

                if (inputNum == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("상태보기");
                    Console.WriteLine("캐릭터의 정보가 표시됩니다.");

                    Console.WriteLine();
                    Console.WriteLine("0. 나가기");
                    outText();
                    int ioutNum = int.Parse(Console.ReadLine());
                    
                    if(ioutNum == 0)
                    {
                        
                    }
                    else
                    {
                        Console.WriteLine("잘못된 입력입니다.");
                    }


                }
                else if (inputNum == 2)
                {
                    Console.WriteLine("인벤토리");
                    Console.WriteLine("보유 증인 아이템을 관리할 수 있습니다.");
                }
                else if (inputNum == 3)
                {
                    Console.WriteLine("상점");
                    Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");
                }
            }
        }
    }
}
