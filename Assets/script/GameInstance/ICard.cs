using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.script.Context;

namespace Assets.script.GameInstance
{
    public abstract class ICard
    {
                public Iplayer player;
        public IGameContext gameContext;

        public ICard(Iplayer player, IGameContext gameContext)
        {
            this.player = player;
            this.gameContext = gameContext;
        }

        public abstract IGameContext play();
    }
}
