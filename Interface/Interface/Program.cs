namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Bird Tweety = new Bird(01);
            Mammal Monkey = new Mammal(6);

            Tweety.MakeSound();
            Monkey.MakeSound();

        }
    }
}
