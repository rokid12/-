using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Sparta
{
    internal class StatusManager
    {
        private static StatusManager _instance;
        public static StatusManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new StatusManager();
                return _instance;
            }
        }

        public string name = "Chad";
        public string classCode = "전사";

        public int level;
        public int levelPoint = 0;

        public float attack = 10f;
        public float plusAttack = 0f;

        public int armor = 5;
        public int plusArmor = 0;

        public int maxHealth = 100;
        public int health = 100;
        public int plusHealth = 0;

        public int gold = 1500;

        public void PlayerInformation()
        {
            Console.WriteLine($"Lv. {PlayerLevel()}");
            Console.WriteLine($"{name} ( {classCode} )");
            Console.Write($"공격력 : {AttackCalculate()}");
            if (plusAttack != 0)
            {
                Console.Write($" + ({plusAttack})");
            }
            Console.Write($"\n방어력 : {ArmorCalculate()}");
            if (plusArmor != 0)
            {
                Console.Write($" + ({plusArmor})");
            }
            Console.Write($"\n체력 : {healthCalculate()}");
            if (plusHealth != 0)
            {
                Console.Write($" + ({plusHealth})");
            }
            Console.WriteLine("\nGold : " + gold + " G");
        }

        public int PlayerLevel()
        {
            if (levelPoint == 0)
            {
                level = 1;
            }
            else if (levelPoint == 1)
            {
                level = 2;
            }
            else if (levelPoint == 3)
            {
                level = 3;
            }
            else if (levelPoint == 6)
            {
                level = 4;
            }
            else if (levelPoint == 10)
            {
                level = 5;
            }
            return level;
        }
        public float AttackCalculate()
        {
            attack = attack + plusAttack + ((float)level * 0.5f - 0.5f);
            return attack;
        }

        public int ArmorCalculate()
        {
            armor = armor + plusArmor + level - 1;
            return armor;
        }

        public int healthCalculate()
        {
            health = health + plusHealth;
            return health;
        }

        public void ItemPlus(int number)
        {
            plusAttack = plusAttack + InventoryManager.inventory[number].itemAttack;
            plusArmor = plusArmor + InventoryManager.inventory[number].itemArmor;
            plusHealth = plusHealth + InventoryManager.inventory[number].itemHealth;
            maxHealth = maxHealth + InventoryManager.inventory[number].itemHealth;
        }

        public void ItemMinus(int number)
        {
            plusAttack = plusAttack - InventoryManager.inventory[number].itemAttack;
            plusArmor = plusArmor - InventoryManager.inventory[number].itemArmor;
            plusHealth = plusHealth - InventoryManager.inventory[number].itemHealth;
            maxHealth = maxHealth - InventoryManager.inventory[number].itemHealth;
        }
    }
}
