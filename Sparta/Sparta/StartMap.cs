using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparta
{
    public static class StartMap
    {
        public static void Show()
        {
            TextManager.Instance.StartMapWelcome();
            TextManager.Instance.StartMapGuide();

            while (true)
            {
                switch (InputManager.Instance.PickNumber())
                {
                    case 1:
                        StatusWindow.Show();
                        return;
                    case 2:
                        InventoryWindow.Show();
                        return;
                    case 3:
                        ShopWindow.Show();
                        return;
                    case 4:
                        DungeonMap.Show();
                        return;
                    case 5:
                        RestWindow.Show();
                        return;
                    default:
                        TextManager.Instance.ErrorOne();
                        break;
                }
            }
        }
    }
}
