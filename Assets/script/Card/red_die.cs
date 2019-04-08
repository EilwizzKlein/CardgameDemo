using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assets.script.Context;
using Assets.script.GameInstance;

namespace Assets.script.Card
{
    class red_die : ICard
    {
        public red_die(Iplayer player, IGameContext gameContext) : base(player, gameContext)
        {
        }

        public override IGameContext play()
        {
           player.getScore(1);
            return this.gameContext;
        }
    }
}
