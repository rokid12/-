using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparta
{
    internal class InventoryManager
    {
        private static InventoryManager _instance;
        public static InventoryManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new InventoryManager();
                return _instance;
            }
        }
        public static List<Item> inventory = new List<Item>();
        public void IndexLoad()
        {
            Console.Write("\n[아이템 목록]");

            for (int i = 0; i < inventory.Count; i++)
            {
                Console.Write($"\n{i + 1}. ");
                inventory[i].ItemInformation();
            }
            Console.WriteLine();
        }
        public void InventoryLoad()
        {
            inventory.Add(ItemManager.Instance.coolCape);
        }
    }
}
