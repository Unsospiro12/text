

using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace ConsoleApp2
{
    internal class Program
    {
        
        public class Warrior
        {
            public int Lv = 1;
            public int attack = 10;
            public int defense = 5;
            public int health = 100;
            public int Gold = 800;
            public int attackBonus;
            public int defenseBonus;
        }

        public class Item
        {
            
        }
        static void StartScreenPrint()
        {
            Console.Clear();
            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
            Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.");
            Console.WriteLine();
            Console.WriteLine("1. 상태 보기");
            Console.WriteLine("2. 인벤토리");
            Console.WriteLine("3. 상점");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.WriteLine(">>");
        }

        static void StatusPrint() 
        {
            Warrior warrior = new Warrior();

            Console.Clear();
            Console.WriteLine("상태 보기");
            Console.WriteLine("캐릭터의 정보가 표시됩니다.");
            Console.WriteLine();
            Console.WriteLine($"Lv {warrior.Lv}");
            Console.WriteLine("Chad ( 전사 )");
            Console.WriteLine($"공격력 : {warrior.attack}");
            Console.WriteLine($"방어력 : {warrior.defense}");
            Console.WriteLine($"체력 : {warrior.health}");
            Console.WriteLine($"Gold : {warrior.Gold} G");
            Console.WriteLine();
            Console.WriteLine("0. 나가기");
        }

        static void InventoryPrint()
        {
            Console.Clear();
            Console.WriteLine("인벤토리");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
            Console.WriteLine();
            Console.WriteLine("[아이템 목록]");
            Console.WriteLine();
            Console.WriteLine($"- [E]무쇠갑옷      | 방어력 +5 | 무쇠로 만들어져 튼튼한 갑옷입니다.");
            Console.WriteLine($"- [E]스파르타의 창 | 공격력 +7 | 스파르타의 전사들이 사용했다는 전설의 창입니다.");
            Console.WriteLine($"- 낡은 검       | 공격력 +2 | 쉽게 볼 수 있는 낡은 검 입니다.");
            Console.WriteLine();
            Console.WriteLine("1. 장착 관리");
            Console.WriteLine("0. 나가기");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.WriteLine(">>");
        }

        static void EquipMentPrint()
        {
            Console.Clear();
            Console.WriteLine("인벤토리 - 장착관리");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
            Console.WriteLine();
            Console.WriteLine("[아이템 목록]");
            Console.WriteLine($"- 1 [E]무쇠갑옷      | 방어력 +5 | 무쇠로 만들어져 튼튼한 갑옷입니다.");
            Console.WriteLine($"- 2 [E]스파르타의 창 | 공격력 +7 | 스파르타의 전사들이 사용했다는 전설의 창입니다.");
            Console.WriteLine($"- 3 낡은 검       | 공격력 +2 | 쉽게 볼 수 있는 낡은 검 입니다.");
            Console.WriteLine();
            Console.WriteLine("0. 나가기");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.WriteLine(">>");
        }

        static void ShopPrint()
        {
            Console.Clear();
            Console.WriteLine("상점");
            Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
            Console.WriteLine();
            Console.WriteLine("[보유 골드]");
            Console.WriteLine("800 G");
            Console.WriteLine();
            Console.WriteLine("-  수련자 갑옷    | 방어력 +5  | 수련에 도움을 주는 갑옷입니다.             |  1000 G");
            Console.WriteLine("-  무쇠갑옷      | 방어력 +9  | 무쇠로 만들어져 튼튼한 갑옷입니다.           |  구매완료");
            Console.WriteLine("-  스파르타의 갑옷 | 방어력 +15 | 스파르타의 전사들이 사용했다는 전설의 갑옷입니다.|  3500 G");
            Console.WriteLine("-  낡은 검      | 공격력 +2  | 쉽게 볼 수 있는 낡은 검 입니다.            |  600 G");
            Console.WriteLine("-  청동 도끼     | 공격력 +5  |  어디선가 사용됐던거 같은 도끼입니다.        |  1500 G");
            Console.WriteLine("-  스파르타의 창  | 공격력 +7  | 스파르타의 전사들이 사용했다는 전설의 창입니다. |  구매완료");
            Console.WriteLine();
            Console.WriteLine("1. 아이템 구매");
            Console.WriteLine("0. 나가기");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.WriteLine(">>");
            Console.WriteLine();
        }

        static void ShopBuyPrint()
        {
            Console.Clear();
            Console.WriteLine("상점 - 아이템 구매");
            Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
            Console.WriteLine();
            Console.WriteLine("[보유 골드]");
            Console.WriteLine("800 G");
            Console.WriteLine();
            Console.WriteLine("[아이템 목록]");
            Console.WriteLine("- 1 수련자 갑옷    | 방어력 +5  | 수련에 도움을 주는 갑옷입니다.             |  1000 G");
            Console.WriteLine("- 2 무쇠갑옷      | 방어력 +9  | 무쇠로 만들어져 튼튼한 갑옷입니다.           |  구매완료");
            Console.WriteLine("- 3 스파르타의 갑옷 | 방어력 +15 | 스파르타의 전사들이 사용했다는 전설의 갑옷입니다.|  3500 G");
            Console.WriteLine("- 4 낡은 검      | 공격력 +2  | 쉽게 볼 수 있는 낡은 검 입니다.            |  600 G");
            Console.WriteLine("- 5 청동 도끼     | 공격력 +5  |  어디선가 사용됐던거 같은 도끼입니다.        |  1500 G");
            Console.WriteLine("- 6 스파르타의 창  | 공격력 +7  | 스파르타의 전사들이 사용했다는 전설의 창입니다. |  구매완료");
            Console.WriteLine();
            Console.WriteLine("0. 나가기");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.WriteLine(">>");
        }

        static void StartScreen()
        {
            StartScreenPrint();
            while (true)
            {
                int Select = int.Parse(Console.ReadLine());
                if (Select == 1)
                {
                    Status();
                }
                else if (Select == 2)
                {
                    Inventory();
                }
                else if (Select == 3)
                {
                    Shop();
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");
                }
            }
        }

        static void Shop()
        {
            ShopPrint();
            while (true)
            {
                int Select = int.Parse(Console.ReadLine());
                if (Select == 1)
                {
                    ShopBuy();
                }
                else if (Select == 0)
                {
                    StartScreen();
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");
                }
            }
        }

        static void Status()
        {
            StatusPrint();
            while (true)
            {
                int Select = int.Parse(Console.ReadLine());
                if (Select == 0)
                {
                    StartScreen();
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");
                }
            }
        }
        static void Inventory()
        {
            InventoryPrint();
            while (true)
            {
                int Select = int.Parse(Console.ReadLine());
                if (Select == 1)
                {
                    EquipMent();
                }
                else if (Select == 0)
                {
                    StartScreen();
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");
                }
            }
        }
        static void EquipMent()
        {
            EquipMentPrint();
            while (true)
            {
                int Select = int.Parse(Console.ReadLine());
                if (Select == 1)
                {
                    
                }
                else if (Select == 2)
                {
                }
                else if (Select == 3)
                {
                }
                else if (Select == 0)
                {
                    Inventory();
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");
                }
            }
        }
        static void ShopBuy()
        {
            ShopBuyPrint();
            while (true)
            {
                int Select = int.Parse(Console.ReadLine());
                if (Select == 1)
                {

                }
                else if (Select == 0)
                {
                    Shop();
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");
                }

            }
        }
            static void Main(string[] args)
            {
                StartScreen();
                Status();
                Inventory();
                EquipMent();
                Shop();
                ShopBuy();
            }
        }
    }

