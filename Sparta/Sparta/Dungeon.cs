using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparta
{
    internal class Dungeon
    {
        public int difficultly;
        int condition;
        
        public void Play()
        {
            if (StatusManager.Instance.health > 1)
            {
                if (StatusManager.Instance.armor > Condition(difficultly))
                {
                    Clear();
                }
                else
                {
                    Random rand = new Random();
                    int clearOrFail = rand.Next(0, 100);


                    if (clearOrFail < 40)
                    {
                        Clear();
                    }
                    else
                    {
                        Fail();
                    }
                }
            }
            else
            {
                TextManager.Instance.ErrorFour();
                DungeonMap.Show();
            }

        }

        public int Condition(int number)
        {
            return condition = 5 + (number * 6);
        }

        string dungeonLevel;

        public void Clear()
        {
            Random rand = new Random();

            int bonus = 0;
            int getGold = 0;
            int bonusGold = 0;
            int totalGold = 0;
            int lessHealth = rand.Next(20 - bonus, 35 - bonus);
            bonus = StatusManager.Instance.armor - Condition(difficultly);
            getGold = 1000 + (difficultly * 650) + (difficultly * difficultly * 50);

            bonusGold = rand.Next((int)(getGold / 100 * StatusManager.Instance.attack), (int)(getGold / 100 * StatusManager.Instance.attack) * 2);
            totalGold = getGold + bonusGold;

            switch (difficultly)
            {
                case 0:
                    dungeonLevel = "쉬운 던전";
                    break;
                case 1:
                    dungeonLevel = "일반 던전";
                    break;
                case 2:
                    dungeonLevel = "어려운 던전";
                    break;
            }

            TextManager.Instance.DungeonClear
                (dungeonLevel, StatusManager.Instance.health, StatusManager.Instance.health - lessHealth, StatusManager.Instance.gold, StatusManager.Instance.gold + totalGold);

            StatusManager.Instance.health = StatusManager.Instance.health - lessHealth;
            StatusManager.Instance.gold = StatusManager.Instance.gold + totalGold;
            StatusManager.Instance.levelPoint = StatusManager.Instance.levelPoint + 1;

            TextManager.Instance.NoneGuide();

            while (true)
            {
                switch (InputManager.Instance.PickNumber())
                {
                    case 0:
                        DungeonMap.Show();
                        return;
                    default:
                        TextManager.Instance.ErrorOne();
                        break;
                }
            }
        }
        public void Fail()
        {
            switch (difficultly)
            {
                case 0:
                    dungeonLevel = "쉬운 던전";
                    break;
                case 1:
                    dungeonLevel = "일반 던전";
                    break;
                case 2:
                    dungeonLevel = "어려운 던전";
                    break;

            }

            TextManager.Instance.DungeonFailed(dungeonLevel, StatusManager.Instance.health, StatusManager.Instance.health / 2);
            StatusManager.Instance.health = StatusManager.Instance.health - (StatusManager.Instance.health / 2);

            TextManager.Instance.NoneGuide();

            while (true)
            {
                switch (InputManager.Instance.PickNumber())
                {
                    case 0:
                        DungeonMap.Show();
                        return;
                    default:
                        TextManager.Instance.ErrorOne();
                        break;
                }
            }
        }
    }
}
