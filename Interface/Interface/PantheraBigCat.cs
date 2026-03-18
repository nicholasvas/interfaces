using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class PantheraBigCat : Mammal
    {
        public string Name { get; set; }
        public PantheraBigCat(float weight, string name) : base(weight)
        {
            Name = name;
        }

        public sealed override void MakeSound()
        {
            Console.WriteLine(this.GetType().Name + " roars");
            
        }
    }
}
