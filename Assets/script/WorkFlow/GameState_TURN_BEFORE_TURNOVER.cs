using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.script.Context;

namespace Assets.script.WorkFlow
{
    class GameState_TURN_BEFORE_TURNOVER : IGameState
    {
        public GameState_TURN_BEFORE_TURNOVER(IGameContext gameContext) : base(gameContext)
        {
            this.CurrentState = 11;
            this.StateName = "本轮结束阶段开始";
        }

        public override IGameState handle()
        {
            bool flag = this.gameContext.GAME_INIT_trigger_LIST.DoTrigger();
            if (flag)
            {
                    return new GameState_TURN_DURING_TURNOVER(this.gameContext);
                

            }
            else
            {
                throw new Exception("脚本运行错误");
            }
        }
    }
}
