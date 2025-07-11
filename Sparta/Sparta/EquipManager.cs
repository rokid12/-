using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparta
{
    internal class EquipManager
    {
        private static EquipManager _instance;
        public static EquipManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EquipManager();
                return _instance;
            }
        }
        public static Item[] equipmentSlots = new Item[3];

        public void EquipUnequip(int number)
        {
            if (equipmentSlots[InventoryManager.inventory[number].itemType] != null)
            {
                UnequipItem(number);
            }

            EquipItem(number);
        }

        public void EquipItem(int number)
        {
            equipmentSlots[InventoryManager.inventory[number].itemType] = InventoryManager.inventory[number];
            Console.WriteLine($"\n{InventoryManager.inventory[number].itemName} 아이템을 장착합니다.");
            StatusManager.Instance.ItemPlus(number);
        }
        public void UnequipItem(int number)
        {
            Console.WriteLine($"\n{equipmentSlots[InventoryManager.inventory[number].itemType].itemName} 아이템의 장착을 해제합니다.");
            equipmentSlots[InventoryManager.inventory[number].itemType] = null;
            StatusManager.Instance.ItemMinus(number);
        }
    }
}
