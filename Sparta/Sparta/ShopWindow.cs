using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Sparta
{
    public class ShopWindow
    {
        public static void Show()
        {
            GameManager.price = true;
            TextManager.Instance.ShopWindowUi();
            ShopManager.Instance.ShopIndexLoad();
            TextManager.Instance.ShopWindowGuide();
            
            while (true)
            {
                switch (InputManager.Instance.PickNumber())
                {
                    case 0:
                        GameManager.price = false;
                        StartMap.Show();
                        return;
                    case 1:
                        Buy();
                        return;
                    case 2:
                        GameManager.price = false;
                        Sell();
                        return;
                    default:
                        TextManager.Instance.ErrorOne();
                        break;

                }
            }
        }

        static void Buy()
        {

            while (true)
            {
                ShopManager.Instance.ShopIndexLoad();
                TextManager.Instance.BuyGuide();
                TextManager.Instance.NoneGuide();

                int pick = InputManager.Instance.PickNumber();

                if (pick == 0)
                {
                    Show();
                    break;
                }
                else if (pick - 1 < ShopManager.shop.Count)
                {
                    if (InventoryManager.inventory.Contains(ShopManager.shop[pick - 1]))
                    {
                        TextManager.Instance.ErrorTwo();
                    }
                    else
                    {
                        if (ShopManager.shop[pick - 1].cost > StatusManager.Instance.gold)
                        {
                            TextManager.Instance.ErrorThree();
                        }
                        else
                        {
                            ShopManager.Instance.BuyItem(pick - 1);
                        }
                    }
                }
                else
                {
                    TextManager.Instance.ErrorOne();
                }
            }
        }

        static void Sell()
        {
            GameManager.sellPrice = true;
            
            while (true)
            {
                TextManager.Instance.HaveGold();
                InventoryManager.Instance.IndexLoad();
                TextManager.Instance.NoneGuide();

                int pick = InputManager.Instance.PickNumber();

                if (pick == 0)
                {
                    GameManager.sellPrice = false;
                    Show();
                    break;
                }
                else if (pick - 1 < InventoryManager.inventory.Count)
                {
                    ShopManager.Instance.SellItem(pick - 1);
                }
                else
                {
                    TextManager.Instance.ErrorOne();
                }
            }
        }
    }
}
