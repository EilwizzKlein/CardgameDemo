using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.script.Context;

namespace Assets.script.WorkFlow
{
    class GameState_TURN_BEFORE_ACTIONOVER : IGameState
    {
        public GameState_TURN_BEFORE_ACTIONOVER(IGameContext gameContext) : base(gameContext)
        {
            this.CurrentState = 8;
            this.StateName = "行动结束开始";
        }

        public override IGameState handle()
        {
            bool flag = this.gameContext.GAME_INIT_trigger_LIST.DoTrigger();
            if (flag)
            {
                    return new GameState_TURN_DURING_ACTIONOVER(this.gameContext);
            }
            else
            {
                throw new Exception("脚本运行错误");
            }
        }
    }
}
