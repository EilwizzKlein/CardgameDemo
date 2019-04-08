using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.script.Context;

namespace Assets.script.WorkFlow
{
    class GameState_TURN_BEFORE_ACTION : IGameState
    {
        public GameState_TURN_BEFORE_ACTION(IGameContext gameContext) : base(gameContext)
        {
            this.CurrentState = 6;
            this.StateName ="第"+((GameContext)this.gameContext).ActionTime+ "次行动开始前,当前玩家是"+this.gameContext.CurrentPlayer.playerName;
        }

        public override IGameState handle()
        {
            bool flag = this.gameContext.GAME_INIT_trigger_LIST.DoTrigger();
            if (flag)
            {

                return new GameState_TURN_DURING_ACTION(this.gameContext);
            }
            else
            {
                throw new Exception("脚本运行错误");
            }
        }
    }
}
