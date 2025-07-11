using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparta
{
    internal class RestWindow
    {
        public static void Show()
        {
            TextManager.Instance.RestWindowUi();
            TextManager.Instance.RestWindowGuide();

            while (true)
            {
                switch (InputManager.Instance.PickNumber())
                {
                    case 0:
                        StartMap.Show();
                        return;
                    case 1:
                        GameManager.Instance.Rest();
                        break;
                    default:
                        TextManager.Instance.ErrorOne();
                        break;

                }
            }
        }
    }
}
