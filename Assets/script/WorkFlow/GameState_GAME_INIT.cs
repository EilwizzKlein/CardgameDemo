using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.script.Context;
using Assets.script.GameInstance;

namespace Assets.script.WorkFlow
{
    public class GameState_GAME_INIT : IGameState
    {

        public GameState_GAME_INIT(IGameContext gameContext):base(gameContext)
        {
            this.CurrentState = 0;
            this.StateName = "对局开始";
        }

        public override IGameState handle()
        {
            init();
           bool flag = this.gameContext.GAME_INIT_trigger_LIST.DoTrigger();
            if (flag) {

            return new GameState_TURN_BEFORE_START(this.gameContext);
            }
            else
            {
                throw new Exception("脚本运行错误");
            }
        }

        //添加玩家
        private void init() {
            Iplayer play1 = new Player( "千叶");
            Iplayer play2 = new Player("yk");
            this.gameContext.PlayerSequence.Add(play1);
            this.gameContext.PlayerSequence.Add(play2);
            this.gameContext.CurrentPlayer = (Player)this.gameContext.PlayerSequence.getT();
        }
    }
}
