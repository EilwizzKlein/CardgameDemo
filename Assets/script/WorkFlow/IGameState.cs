using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.script.Context;

namespace Assets.script.WorkFlow
{
    //游戏状态接口
    public abstract  class IGameState
    {
        public const int GAME_INIT = 0;//游戏初始化
        public const int TURN_BEFORE_START = 1;//本轮开始前
        public const int TURN_DURING_START = 2;//本轮开始时
        public const int TURN_AFTER_START = 3;//本轮开始后
        public const int TURN_BEFORE_DRAWING = 4;//抽牌前
        public const int TURN_AFTER_DRAWING = 5;//抽牌后
        public const int TURN_BEFORE_ACTION = 6;//行动阶段开始前
        public const int TURN_DURING_ACTION = 7;//行动阶段中
        public const int TURN_BEFORE_ACTIONOVER = 8;//行动结束开始前
        public const int TURN_DURING_ACTIONOVER = 9;//行动结束
        public const int TURN_AFTER_ACTIONOVER = 10;//行动结束后
        public const int TURN_BEFORE_TURNOVER = 11;//本轮结束前
        public const int TURN_DURING_TURNOVER = 12;//本轮结束时
        public const int TURN_AFTER_TURNOVER = 13;//本轮结束后

        public int CurrentState;
        public IGameContext gameContext;
        public string StateName;

        public IGameState(IGameContext gameContext) {
            this.gameContext = gameContext;

        }
        public void NextState() {
            this.gameContext.CurrentGameState = this.handle();
        }

        public abstract IGameState handle();
    }
}
