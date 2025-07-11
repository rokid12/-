using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sparta
{
    public class ItemManager
    {
        private static ItemManager _instance;
        public static ItemManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ItemManager();
                return _instance;
            }
        }
        public Item traineeArmor = new Item
        {
            itemName = "수련자 갑옷",
            itemInformation = "수련에 도움을 주는 갑옷입니다.",
            itemAttack = 0,
            itemArmor = 5,
            itemHealth = 0,
            itemType = 0,
            cost = 1000
        };
        public Item steelArmor = new Item
        {
            itemName = "무쇠 갑옷",
            itemInformation = "무쇠로 만들어져 튼튼한 갑옷입니다.",
            itemAttack = 0,
            itemArmor = 9,
            itemHealth = 0,
            itemType = 0,
            cost = 2000
        };
        public Item spartaArmor = new Item
        {
            itemName = "스파르타 갑옷",
            itemInformation = "스파르타 전사들이 사용했다는 전설의 갑옷입니다.",
            itemAttack = 0,
            itemArmor = 15,
            itemHealth = 0,
            itemType = 0,
            cost = 3500
        };
        public Item oldSword = new Item
        {
            itemName = "낡은 검",
            itemInformation = "쉽게 볼 수 있는 낡은 검 입니다.",
            itemAttack = 2,
            itemArmor = 0,
            itemHealth = 0,
            itemType = 1,
            cost = 600
        };
        public Item bronzeAxe = new Item
        {
            itemName = "청동 도끼",
            itemInformation = "어디선가 사용됐던거 같은 도끼입니다.",
            itemAttack = 5,
            itemArmor = 0,
            itemHealth = 0,
            itemType = 1,
            cost = 1500
        };
        public Item spartaSpear = new Item
        {
            itemName = "스파르타의 창",
            itemInformation = "스파르타 전사들이 사용했다는 전설의 창입니다.",
            itemAttack = 7,
            itemArmor = 0,
            itemHealth = 0,
            itemType = 1,
            cost = 3000
        };
        public Item coolCape = new Item
        {
            itemName = "멋진 망토",
            itemInformation = "빨간색의 멋진 망토입니다.",
            itemAttack = 0,
            itemArmor = 0,
            itemHealth = 1,
            itemType = 2,
            cost = 0
        };
    }
}
