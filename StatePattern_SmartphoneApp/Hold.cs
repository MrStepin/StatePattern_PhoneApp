using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern_SmartphoneApp
{
    public class Hold : IState
    {
        public  void Call(Phone phone)
        {
            phone.State = new Connecting();
            Console.WriteLine($"State is changed to {phone.State.GetType().Name}");
        }
        public  void HangUp(Phone phone)
        {
            phone.State = new NoCall();
            Console.WriteLine($"State is changed to {phone.State.GetType().Name}");
        }
        public  void RemoveFromHold(Phone phone)
        {
            phone.State = new Connected();
            Console.WriteLine($"State is changed to {phone.State.GetType().Name}");
        }
        public void PutOnHold(Phone phone) { Console.WriteLine("Error, impossible state!"); }

        public void PickUp(Phone phone) { Console.WriteLine("Error, impossible state!"); }

    }
}
