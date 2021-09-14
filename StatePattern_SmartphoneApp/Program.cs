using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern_SmartphoneApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone(new NoCall());
            phone.Call();
            phone.HangUp();
            phone.Call();
            phone.PickUp();
            phone.PutOnHold();
            phone.RemoveFromHold(); 
            phone.PutOnHold();
            phone.HangUp();

            Console.ReadKey();
        }
    }
}
