using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern_SmartphoneApp
{
    public class NoCall : IState
    {
        public void PickUp(Phone phone)
        {
            phone.State = new Connected();
            Console.WriteLine($"State is changed to {phone.State.GetType().Name}");
        }
        public void Call(Phone phone)
        {
            phone.State = new Connecting();
            Console.WriteLine($"State is changed to {phone.State.GetType().Name}");
        }

        public void HangUp(Phone phone)
        {
            Console.WriteLine("Error, impossible state!");}

        public void PutOnHold(Phone phone) { Console.WriteLine("Error, impossible state!"); }

        public void RemoveFromHold(Phone phone) { Console.WriteLine("Error, impossible state!"); }
    }
}
