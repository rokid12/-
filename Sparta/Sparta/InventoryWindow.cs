using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparta
{
    public class InventoryWindow
    {

        public static void Show()
        {
            TextManager.Instance.InventoryWindowUi();
            InventoryManager.Instance.IndexLoad();
            TextManager.Instance.InventoryWindowGuide();

            while (true)
            {
                switch (InputManager.Instance.PickNumber())
                {
                    case 0:
                        StartMap.Show();
                        return;
                    case 1:
                        Equip();
                        return;
                    default:
                        TextManager.Instance.ErrorOne();
                        break;
                }
            }
        }
        public static void Equip()
        {
            while (true)
            {
                TextManager.Instance.InventoryEquip();
                InventoryManager.Instance.IndexLoad();
                TextManager.Instance.NoneGuide();

                int pick = InputManager.Instance.PickNumber();

                if (pick == 0)
                {
                    Show();
                    break;
                }
                else if (pick - 1 < InventoryManager.inventory.Count)
                {
                    EquipManager.Instance.EquipUnequip(pick - 1);
                }
                else
                {
                    TextManager.Instance.ErrorOne();
                }
            }
        }
    }
}
