using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.script.Context;

namespace Assets.script.WorkFlow
{
    class GameState_TURN_DURING_TURNOVER : IGameState
    {
        public GameState_TURN_DURING_TURNOVER(IGameContext gameContext) : base(gameContext)
        {
            this.CurrentState = 12;
            this.StateName = "本轮结束时";
        }

        public override IGameState handle()
        {
            bool flag = this.gameContext.GAME_INIT_trigger_LIST.DoTrigger();
            if (flag)
            {
                return new GameState_TURN_AFTER_TURNOVER(this.gameContext);


            }
            else
            {
                throw new Exception("脚本运行错误");
            }
        }
    }
}
