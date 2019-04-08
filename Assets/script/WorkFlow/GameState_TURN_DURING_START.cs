using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.script.Context;

namespace Assets.script.WorkFlow
{
    class GameState_TURN_DURING_START : IGameState
    {

        public GameState_TURN_DURING_START(IGameContext gameContext) : base(gameContext)
        {
            this.CurrentState = 2;
            this.StateName ="第"+ this.gameContext.turnNumber + "回合开始中";
        }

        public override IGameState handle()
        {
            bool flag = this.gameContext.GAME_INIT_trigger_LIST.DoTrigger();
            if (flag)
            {

                return new GameState_TURN_AFTER_START(this.gameContext);
            }
            else
            {
                throw new Exception("脚本运行错误");
            }
        }
    }
}
