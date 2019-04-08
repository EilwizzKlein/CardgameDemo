using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.script.GameInstance;
using Assets.script.Context;

namespace Assets.script.trigger
{
    internal abstract class ITriggerList

    {
        internal IGameContext gameContext;
        internal List<ITrigger> observerList; //触发器列表
        internal abstract int AddTrigger(ITrigger trigger);//注册触发器,返回ID值
        internal abstract bool DeleteTrigger(int ID);//删除触发器
        internal abstract bool DoTrigger();//执行触发器

        internal ITriggerList(IGameContext gameContext) {
            this.gameContext = gameContext;
            this.observerList = new List<ITrigger>();
        }
    }
}
