using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.script.Context;

namespace Assets.script.WorkFlow
{
    class GameState_TURN_AFTER_TURNOVER : IGameState
    {
        public GameState_TURN_AFTER_TURNOVER(IGameContext gameContext) : base(gameContext)
        {
            this.CurrentState = 13;
            this.StateName = "本轮结束后";
        }

        public override IGameState handle()
        {
            bool flag = this.gameContext.GAME_INIT_trigger_LIST.DoTrigger();
            if (flag)
            {
                this.gameContext.turnNumber = this.gameContext.turnNumber + 1;
                return new GameState_TURN_BEFORE_START(this.gameContext);


            }
            else
            {
                throw new Exception("脚本运行错误");
            }
        }
    }
}
