using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Tiger: PantheraBigCat, IMove
    {
        public Tiger (float weight, string name) : base (weight, name)
        {

        }

        public void Move()
        {
            Console.WriteLine("this tiger is moving");
        }

    

    }
}
