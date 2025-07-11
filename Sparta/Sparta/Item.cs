using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sparta
{
    public class Item
    {
        public int itemId;
        public string itemName;
        public string itemInformation;
        public int itemAttack;
        public int itemArmor;
        public int itemHealth;
        public int itemType;
        public int cost;

        public void ItemInformation()
        {
            List<string> statusList = new List<string>();

            string ItemStatusType()
            {
                if (itemAttack != 0)
                {
                    statusList.Add($"공격력 + {itemAttack}");
                }
                if (itemArmor != 0)
                {
                    statusList.Add($"방어력 + {itemArmor}");
                }
                if (itemHealth != 0)
                {
                    statusList.Add($"체력 + {itemHealth}");
                }
                return string.Join(", ", statusList);
            }


            if (EquipManager.equipmentSlots.Contains(this))
            {
                if (GameManager.price != true)
                {
                    Console.Write("[E] ");
                }
            }
            Console.Write(itemName);
            Console.Write($" | {ItemStatusType()} | ");
            Console.Write(itemInformation);
            if (GameManager.price == true)
            {
                Console.Write(" | ");
                if (InventoryManager.inventory.Contains(this))
                {
                    Console.Write("구매 완료");
                }
                else
                {
                    Console.Write($"{cost} G");
                }   
            }
            if (GameManager.sellPrice == true)
            {
                Console.Write($" | {cost / 100 * 85} G");
            }
        }
    }
}