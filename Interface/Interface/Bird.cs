using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Bird : Animal
    {

        public Bird(float weight) : base(weight) { 
        }

        public override void MakeSound()
        {
            Console.WriteLine("Chirp");
        }
    }
}
