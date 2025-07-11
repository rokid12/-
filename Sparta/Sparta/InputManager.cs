using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparta
{
    internal class InputManager
    {
        private static InputManager _instance;
        public static InputManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new InputManager();
                return _instance;
            }
        }
        public int PickNumber()
        {
            while (true)
            {
                TextManager.Instance.InputGuide();
                string input = Console.ReadLine();

                if (int.TryParse(input, out int selectNumber) && selectNumber >= 0)
                {
                    return selectNumber;
                }
                else
                {
                    TextManager.Instance.ErrorOne();
                }
            }
        }
    }
}
