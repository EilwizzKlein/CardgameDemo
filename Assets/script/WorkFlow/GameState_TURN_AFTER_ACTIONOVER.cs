using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.script.Context;

namespace Assets.script.WorkFlow
{
    class GameState_TURN_AFTER_ACTIONOVER : IGameState
    {
        public GameState_TURN_AFTER_ACTIONOVER(IGameContext gameContext) : base(gameContext)
        {
            this.CurrentState = 10;
            this.StateName = "当前玩家"+this.gameContext.CurrentPlayer.playerName+"行动结束";
        }

        public override IGameState handle()
        {
            bool flag = this.gameContext.GAME_INIT_trigger_LIST.DoTrigger();
            if (flag)
            {
                if (((GameContext)this.gameContext).ActionTime >= 20)
                {
                    return new GameState_TURN_BEFORE_TURNOVER(this.gameContext);
                }
                else
                {
                    ((GameContext)this.gameContext).ActionTime = ((GameContext)this.gameContext).ActionTime + 1;
                    this.gameContext.CurrentPlayer= this.gameContext.PlayerSequence.Next();
                    return new GameState_TURN_BEFORE_ACTION(this.gameContext);
                }

            }
            else
            {
                throw new Exception("脚本运行错误");
            }
        }
    }
}
