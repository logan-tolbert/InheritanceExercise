using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Animal
    {
        public string Movement { get; set; }
        public string Diet { get; set; }
        public string Voice { get; set; }
        public string Color { get; set; }  
        public int NumberOfLegs { get; set; }
        
        public void Speak()
        {
            Console.Write(Voice);
        }

    }


}
