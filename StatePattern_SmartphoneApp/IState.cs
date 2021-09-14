using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern_SmartphoneApp
{
    public interface IState
    {
        void HangUp(Phone phone);

        void PutOnHold(Phone phone);

        void PickUp(Phone phone);

        void Call(Phone phone);

        void RemoveFromHold(Phone phone);
    }
}
