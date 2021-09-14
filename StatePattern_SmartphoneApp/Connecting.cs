using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern_SmartphoneApp
{
    public class Connecting : IState
    {
        public  void HangUp(Phone phone)
        {
            phone.State = new NoCall();
            Console.WriteLine($"State is changed to {phone.State.GetType().Name}");
        }

        public void PickUp(Phone phone)
        {
            phone.State = new Connected();
            Console.WriteLine($"State is changed to {phone.State.GetType().Name}");
        }

        public void PutOnHold(Phone phone) { Console.WriteLine("Error, impossible state!"); }

        public void Call(Phone phone) { Console.WriteLine("Error, impossible state!"); }

        public void RemoveFromHold(Phone phone) { Console.WriteLine("Error, impossible state!"); }
    }
}
