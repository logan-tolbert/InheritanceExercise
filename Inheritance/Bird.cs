using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird() { }

        public bool CanFly { get; set; }
        public string BeakOrBill { get; set; }
        private bool _isFlying = false;
        
        public void Fly() 
        {   if (CanFly)
            {
               Console.Write("flap wings,and fly through the air.");
                _isFlying = true;
            }
            else
            {
                Console.Write("This bird does not fly.");
                _isFlying = false;
            }
        }


        public void PoopOnCar()
        { 
            if (_isFlying)
            {
                Console.Write("Target hit!!!!");
            }
        }

        

    }
}
