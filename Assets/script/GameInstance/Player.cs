using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.script.Context;

namespace Assets.script.GameInstance
{
    class Player : Iplayer
    {
        public Player()
        {
        }

        public Player(string playerName) : base(playerName)
        {
        }

        public Player(int ID) : base(ID)
        {
        }

        public override Iplayer getScore(int i) {
            this.Score += i;
            
            return this;
        }
    }
}
