using System.Net.Security;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Sparta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InventoryManager.Instance.InventoryLoad();
            ShopManager.Instance.ShopLoad();
            StartMap.Show();
        }
    }
}