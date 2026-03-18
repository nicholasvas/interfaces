using System.Runtime.CompilerServices;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Bird Tweety = new Bird(01);
            Mammal Monkey = new Mammal(6);
            PantheraBigCat Panthera = new PantheraBigCat(15, "PinkPantheress");
            Tiger Nala = new Tiger(30, "Nala");

            Tweety.MakeSound();
            Monkey.MakeSound();
            Panthera.MakeSound();
            Nala.Move();
            Nala.MakeSound();

            //for testing purposes
            Console.WriteLine("---------------------- ANYTHING BELOW THIS LINE IS FOR MY TESTING PURPOSES----------------------------------");

            Console.WriteLine(Panthera.Name + " roars again");
            Console.WriteLine(Nala.Name + " the " + Nala.GetType().Name.ToLower() + " is runnning wild and free");


        }
    }
}
