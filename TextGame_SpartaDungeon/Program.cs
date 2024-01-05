using System.Net.Security;
using System.Runtime.Intrinsics.X86;

namespace TextGame_SpartaDungeon
{
    struct player
    {
        public int level;
        public string Name;
        public int attackStat;
        public int defenseStat;
        public int hp;
        public int gold;

        public void PrintInfo()
        {
            Console.WriteLine($" LV. {level}\n {Name+"  ( 전사 )"}\n 공격력 : {attackStat}\n 방어력 : {defenseStat}\n 체력   : {hp}\n Gold   : {gold} G ");
        }
    }

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
            int outNum;

            Console.WriteLine("0. 나가기");
            Console.WriteLine("원하시는 행동을 입력해 주세요.");
            Console.Write(">> ");
            outNum = int.Parse(Console.ReadLine());

            while (outNum != 0)
            {
                Console.WriteLine("잘못된 입력입니다. 다시 입력해 주세요.");
                Console.Write(">>");
                outNum=int.Parse( Console.ReadLine());
                
                if(outNum == 0)
                {
                    break;
                }
            }   
        }

        static void states()
        {
            player player1;
            player1.level = 01;
            player1.Name = "Chad";
            player1.attackStat = 10;
            player1.defenseStat = 5;
            player1.hp = 100;
            player1.gold=1500;
            player1.PrintInfo();
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine();
                intro();
                string inputNum = Console.ReadLine();

                switch (inputNum)
                {
                    case "1":

                        Console.WriteLine();
                        Console.WriteLine("상태보기");
                        Console.WriteLine("캐릭터의 정보가 표시됩니다.");
                        Console.WriteLine();
                        states ();

                        Console.WriteLine();

                        outText();
                        break;

                    case "2":
                        Console.WriteLine();
                        Console.WriteLine("인벤토리");
                        Console.WriteLine("보유 증인 아이템을 관리할 수 있습니다.");

                        Console.WriteLine() ;
                        Console.WriteLine("1. 장착관리");

                        outText();
                        break;

                    case "3":
                        Console.WriteLine();
                        Console.WriteLine("상점");
                        Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");

                        Console.WriteLine();
                        Console.WriteLine("1. 아이템 구매");

                        outText();
                        break;

                    default : 
                        Console.WriteLine();
                        Console.WriteLine("잘못된 입력입니다.");
                        break;
                }
            }
        }
    }
}
