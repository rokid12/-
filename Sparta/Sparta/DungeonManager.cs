using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparta
{
    internal class DungeonManager
    {
        private static DungeonManager _instance;
        public static DungeonManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DungeonManager();
                return _instance;
            }
        }

        public Dungeon easyDungeon = new Dungeon
        {
            difficultly = 0
        };
        public Dungeon normalDungeon = new Dungeon
        {
            difficultly = 1
        };
        public Dungeon hardDungeon = new Dungeon
        {
            difficultly = 2
        };
    }
}
