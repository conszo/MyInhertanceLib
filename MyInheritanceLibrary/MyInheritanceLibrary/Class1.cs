namespace MyInheritanceLibrary
{
    public class Animal
    {
        public string name { get; set; }
        public int age { get; set; }
        public int legs { get; set; }

    }
    public void Speak()
    {
        Console.WriteLine("Hello");

    }
    public class Dog : Animal
    {
        public void Bark()
        {
            Console.Write("bark bark");
        }

    }
    public class Cat : Animal
    {
        public void Meow()
        {
            Console.Write("meow meow");
        }

    }
    public class Bird : Animal
    {
        public void Chirp()
        {
            Console.Write("chirp chirp");
        }

    }
}
