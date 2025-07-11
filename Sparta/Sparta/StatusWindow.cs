using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparta
{
    public class StatusWindow
    {
        public static void Show()
        {
            TextManager.Instance.StatusWindowUi();
            StatusManager.Instance.PlayerInformation();
            TextManager.Instance.NoneGuide();

            while (true)
            {
                switch (InputManager.Instance.PickNumber())
                {
                    case 0:
                        StartMap.Show();
                        return;
                    default:
                        TextManager.Instance.ErrorOne();
                        break;
                }
            }
        }
    }
}
