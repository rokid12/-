using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sparta
{
    public class GameManager
    {
        private static GameManager _instance;
        public static GameManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GameManager();
                return _instance;
            }
        }
        public static bool price = false;
        public static bool sellPrice = false;

        public void Rest()
        {
            if (StatusManager.Instance.gold > 500)
            {
                if (StatusManager.Instance.health + 100 > StatusManager.Instance.maxHealth)
                {
                    TextManager.Instance.GetHealth(StatusManager.Instance.maxHealth - StatusManager.Instance.health);
                    StatusManager.Instance.health = StatusManager.Instance.maxHealth;
                }
                else
                {
                    TextManager.Instance.GetHealth(100);
                    StatusManager.Instance.health = StatusManager.Instance.health + 100;
                }
                StatusManager.Instance.gold = StatusManager.Instance.gold - 500;
                TextManager.Instance.LostGold(500);
                TextManager.Instance.Rest();
            }
            else
            {
                TextManager.Instance.ErrorThree();
            }
        }
    }
}
