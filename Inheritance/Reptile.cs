using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public bool CanChangeColor;
        public bool LaysEggs;

        public void ShedSkin()
        {
            Console.WriteLine("I feel like a new snake, I think I even grew some");
        }

        public void Camoflage()
        {
            if (CanChangeColor)
            {
                Console.WriteLine("Color change complete");
            }
            else
            {
                Console.WriteLine("Now no one will see me!!");
            }
        }
    }
}
