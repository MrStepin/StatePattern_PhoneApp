using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern_SmartphoneApp
{
    public class Phone
    {
        public IState State { get; set; }
        public Phone(IState state)
        {
            State = state;
        }

        public void HangUp()
        {
            State.HangUp(this);
        }

        public void PutOnHold()
        {
            State.PutOnHold(this);
        }

        public void PickUp()
        {
            State.PickUp(this);
        }

        public void Call()
        {
            State.Call(this);
        }

        public void RemoveFromHold()
        {
            State.RemoveFromHold(this);
        }
    }

}
