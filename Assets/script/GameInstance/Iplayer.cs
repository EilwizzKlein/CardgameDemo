using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.script.Context;

namespace Assets.script.GameInstance
{
    //玩家接口
    public abstract class Iplayer
    {
        public string playerName;
        public int playerID;
        public int Score = 0;

        public Iplayer() { 
        }
        public Iplayer(string playerName) {
            this.playerName = playerName;
        }

        public Iplayer(int ID) {
            this.playerID = ID;
        }

        public abstract Iplayer getScore(int i);
    }
}
