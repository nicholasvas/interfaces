using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Penguin : Bird, IMove
    {

        public Penguin(float weight) : base(weight)
        {


        }

        public override void MakeSound()
        {
            Console.WriteLine("AAAHH");
        }


        public void Move()
        {
            Console.WriteLine("Penguin is waddling");
        }


    }
    
}
