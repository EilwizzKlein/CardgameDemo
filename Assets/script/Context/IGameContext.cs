using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.script.WorkFlow;
using Assets.script.trigger;
using Assets.script.GameInstance;
using Assets.script.Manager;


namespace Assets.script.Context
{
    //对局上下文
    public abstract class IGameContext
    {
        public IGameState CurrentGameState;
        internal ITriggerList GAME_INIT_trigger_LIST;
        internal Iplayer CurrentPlayer;
        internal CircleLink<Iplayer> PlayerSequence;

        internal int turnNumber = 1; //回合数

        public IGameContext()
        {
            this.CurrentGameState = new GameState_GAME_INIT(this);
            this.GAME_INIT_trigger_LIST = new GAME_INIT_trigger_LIST(this);
            this.PlayerSequence = new CircleLink<Iplayer>();
        }
    }
}
