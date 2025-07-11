using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparta
{
    internal class ShopManager
    {
        private static ShopManager _instance;
        public static ShopManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ShopManager();
                return _instance;
            }
        }

        public static List<Item> shop = new List<Item>();

        public void ShopIndexLoad()
        {
            Console.WriteLine("\n[아이템 목록]");

            for (int i = 0; i < shop.Count; i++)
            {
                Console.Write($"\n{i + 1}. ");
                shop[i].ItemInformation();
            }
            Console.WriteLine();
        }
        public void ShopLoad()
        {
            shop.Add(ItemManager.Instance.traineeArmor);
            shop.Add(ItemManager.Instance.steelArmor);
            shop.Add(ItemManager.Instance.spartaArmor);
            shop.Add(ItemManager.Instance.oldSword);
            shop.Add(ItemManager.Instance.bronzeAxe);
            shop.Add(ItemManager.Instance.spartaSpear);
        }

        public void BuyItem(int number)
        {
            StatusManager.Instance.gold = StatusManager.Instance.gold - ShopManager.shop[number].cost;
            TextManager.Instance.LostGold(ShopManager.shop[number].cost);
            TextManager.Instance.GetItem(ShopManager.shop[number]);
            InventoryManager.inventory.Add(shop[number]);
        }

        public void SellItem(int number)
        {
            if (EquipManager.equipmentSlots.Contains(InventoryManager.inventory[number]))
            {
                EquipManager.Instance.UnequipItem(number);
            }

            StatusManager.Instance.gold = StatusManager.Instance.gold + InventoryManager.inventory[number].cost / 100 * 85;
            TextManager.Instance.GetGold(InventoryManager.inventory[number].cost / 100 * 85);
            TextManager.Instance.LostItem(InventoryManager.inventory[number]);
            InventoryManager.inventory.Remove(InventoryManager.inventory[number]);
        }
    }
}
