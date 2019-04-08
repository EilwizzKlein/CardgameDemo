using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.script.GameInstance;
using Assets.script.Context;

namespace Assets.script.Manager
{
   public class GameContentManager
    {
        IGameContext gameContext;

        public GameContentManager(IGameContext gameContext)
        {
            this.gameContext = gameContext;
        }

        public void switchPlayer() {

        }
    }
}
