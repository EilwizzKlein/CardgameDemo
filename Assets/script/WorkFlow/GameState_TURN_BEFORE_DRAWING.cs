using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.script.Context;

namespace Assets.script.WorkFlow
{
    class GameState_TURN_BEFORE_DRAWING : IGameState
    {
        public GameState_TURN_BEFORE_DRAWING(IGameContext gameContext) : base(gameContext)
        {
            this.CurrentState = 4;
            this.StateName = "抽卡前";
        }

        public override IGameState handle()
        {
            bool flag = this.gameContext.GAME_INIT_trigger_LIST.DoTrigger();
            if (flag)
            {

                return new GameState_TURN_AFTER_DRAWING(this.gameContext);
            }
            else
            {
                throw new Exception("脚本运行错误");
            }
        }
    }
}
