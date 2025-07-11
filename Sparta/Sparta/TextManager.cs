using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparta
{
    public class TextManager
    {
        private static TextManager _instance;
        public static TextManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TextManager();
                return _instance;
            }
        }
        public void ErrorOne()
        {
            Console.WriteLine("\n잘못된 입력입니다.");
        }
        public void ErrorTwo()
        {
            Console.WriteLine("\n이미 보유중인 아이템입니다.");
        }
        public void ErrorThree()
        {
            Console.WriteLine("\n골드가 부족합니다.");
        }
        public void ErrorFour()
        {
            Console.WriteLine("\n체력이 부족합니다.");
        }
        public void StartMapWelcome()
        {
            Console.WriteLine("\n스파르타 마을에 오신 여러분 환영합니다.");
            Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.");
        }
        public void StartMapGuide()
        {
            Console.WriteLine("\n1. 상태 보기");
            Console.WriteLine("2. 인벤토리");
            Console.WriteLine("3. 상점");
            Console.WriteLine("4. 던전 입장");
            Console.WriteLine("5. 휴식하기");
        }
        public void InputGuide()
        {
            Console.WriteLine("\n원하시는 행동을 입력해 주세요.");
            Console.Write(">>");
        }
        public void StatusWindowUi()
        {
            Console.WriteLine("\n상태 보기");
            Console.WriteLine("캐릭터의 정보가 표시됩니다.");
        }
        public void NoneGuide()
        {
            Console.WriteLine("\n0. 나가기");
        }
        public void InventoryWindowUi()
        {
            Console.WriteLine("\n인벤토리");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
        }
        public void InventoryWindowGuide()
        {
            Console.WriteLine("\n1. 아이템 관리");
            Console.WriteLine("0. 나가기");
        }
        public void InventoryEquip()
        {
            Console.WriteLine("\n인벤토리 - 장착 관리");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
        }
        public void ShopWindowUi()
        {
            Console.WriteLine("\n상점");
            Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
        }
        public void HaveGold()
        {
            Console.WriteLine("\n[보유 골드]");
            Console.WriteLine($"{StatusManager.Instance.gold} G");
        }
        public void ShopWindowGuide()
        {
            Console.WriteLine("\n1. 아이템 구매");
            Console.WriteLine("2. 아이템 판매");
            Console.WriteLine("0. 나가기");
        }
        public void BuyGuide()
        {
            Console.WriteLine("\n구매하실 아이템의 번호를 입력해주세요.");
        }
        public void RestWindowUi()
        {
            Console.WriteLine("\n휴식하기");
            Console.WriteLine($"500 G 를 내면 휴식할 수 있습니다. (보유 골드 : {StatusManager.Instance.gold} G)"); 
        }
        public void RestWindowGuide()
        {
            Console.WriteLine("\n1. 휴식하기");
            Console.WriteLine("0. 나가기");
        }
        public void Rest()
        {
            Console.WriteLine("\n휴식이 완료되었습니다.");
        }
        public void LostGold(int number)
        {
            Console.WriteLine($"\n{number} G 를 잃었습니다.");
        }
        public void GetGold(int number)
        {
            Console.WriteLine($"\n{number} G 를 얻었습니다.");
        }
        public void LostItem(Item item)
        {
            Console.WriteLine($"\n{item.itemName} 아이템을 잃었습니다.");
        }
        public void GetItem(Item item)
        {
            Console.WriteLine($"\n{item.itemName} 아이템을 얻었습니다.");
        }
        public void LostHealth(int number)
        {
            Console.WriteLine($"\n체력을 {number} 잃었습니다.");
        }
        public void GetHealth(int number)
        {
            Console.WriteLine($"\n체력을 {number} 얻었습니다.");
        }
        public void DungeonWindowUi()
        {
            Console.WriteLine("\n던전 입장");
            Console.WriteLine("이곳에서 던전으로 들어가기 전 활동을 할 수 있습니다.");
        }
        public void DungeonWindowGuide()
        {
            Console.WriteLine($"\n1. 쉬운 던전 | 방어력 5 이상 권장");
            Console.WriteLine($"2. 일반 던전 | 방어력 11 이상 권장");
            Console.WriteLine($"3. 어려운 던전 | 방어력 16 이상 권장");
        }
        public void DungeonClear(string difficultly, int healthBefore, int healthAfter, int goldBefore, int goldAfter)
        {
            Console.WriteLine("\n던전 클리어");
            Console.WriteLine("축하합니다!!");
            Console.WriteLine($"{difficultly}을 클리어 하였습니다.");
            Console.WriteLine("\n[탐험 결과]");
            Console.WriteLine($"체력 {healthBefore} -> {healthAfter}");
            Console.WriteLine($"Gold {goldBefore} G -> {goldAfter}");
        }
        public void DungeonFailed(string difficultly, int healthBefore, int healthAfter)
        {
            Console.WriteLine("\n던전 실패");
            Console.WriteLine($"{difficultly}에 실패 하였습니다.");
            Console.WriteLine("\n[탐험 결과]");
            Console.WriteLine($"체력 {healthBefore} -> {healthAfter}");
        }
    }
}
