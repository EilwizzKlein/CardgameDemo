using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.script.Context;

namespace Assets.script.trigger
{
    internal class GAME_INIT_trigger_LIST : ITriggerList
    {


        internal GAME_INIT_trigger_LIST(IGameContext gameContext) : base(gameContext)
        {
        }

        internal override int AddTrigger(ITrigger trigger)
        {
            throw new NotImplementedException();
        }

        internal override bool DeleteTrigger(int ID)
        {
            throw new NotImplementedException();
        }

        internal override bool DoTrigger()
        {
            try
            {
                if (this.observerList!=null && this.observerList.Count > 0)
                {
                    for (int i = 0; i < this.observerList.Count; i++) {
                        this.observerList[i].Action(this.gameContext);
                    }
                }
                return true;
            }
            catch(Exception ex) {
                throw ex;
                //return false;
            }
            
        }
    }
}
