using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal abstract class Animal
    {
        float Weight { get; set; }

     public Animal(float weight)
        {
            Weight = weight;
        }

        public virtual void MakeSound() { Console.WriteLine("test"); }



    }
}
