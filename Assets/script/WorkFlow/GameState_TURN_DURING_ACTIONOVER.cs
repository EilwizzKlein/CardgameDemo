using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.script.Context;

namespace Assets.script.WorkFlow
{
    class GameState_TURN_DURING_ACTIONOVER : IGameState
    {
        public GameState_TURN_DURING_ACTIONOVER(IGameContext gameContext) : base(gameContext)
        {
            this.StateName = "行动结束阶段";
            this.CurrentState = 9;
        }

        public override IGameState handle()
        {
            bool flag = this.gameContext.GAME_INIT_trigger_LIST.DoTrigger();
            if (flag)
            {

                return new GameState_TURN_AFTER_ACTIONOVER(this.gameContext);
            }
            else
            {
                throw new Exception("脚本运行错误");
            }
        }
    }
}
