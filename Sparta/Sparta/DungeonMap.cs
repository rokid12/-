using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparta
{
    internal class DungeonMap
    {
        public static void Show()
        {
            while (true)
            {
                TextManager.Instance.DungeonWindowUi();
                TextManager.Instance.DungeonWindowGuide();

                switch (InputManager.Instance.PickNumber())
                {
                    case 0:
                        StartMap.Show();
                        return;
                    case 1:
                        DungeonManager.Instance.easyDungeon.Play();
                        continue;
                    case 2:
                        DungeonManager.Instance.normalDungeon.Play();
                        continue;
                    case 3:
                        DungeonManager.Instance.hardDungeon.Play();
                        continue;
                    default:
                        TextManager.Instance.ErrorOne();
                        break;
                }
            }
        }

        
    }
}
