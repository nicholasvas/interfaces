using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Mammal : Animal
    {

        public Mammal(float weight) : base(weight)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Roar!");
        }
    }
}
