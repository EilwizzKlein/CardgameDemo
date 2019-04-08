using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.script.GameInstance;
using Assets.script.Context;


namespace Assets.script.trigger
{
    internal abstract class ITrigger
    {
        internal Iplayer triggerPlayer; //触发玩家
        internal ICard triggerSource;  //触发来源
        internal List<ICard> target;  //目标
        internal int ID;//触发器编码
        internal abstract void Action(IGameContext gameContext); //效果

    }
}
