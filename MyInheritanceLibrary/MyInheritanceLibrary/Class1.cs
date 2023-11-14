namespace MyInheritanceLibrary
{
    public class Animal
    {
        public string name { get; set; }
        public int age { get; set; }
        public int legs { get; set; }

        public Animal()
        {
            name = "";
            age = 0;
            legs = 0;
        }

        public Animal(string name, int age, int legs)
        {
            this.name = name;
            this.age = age;
            this.legs = legs;
        }
    }
    public void Speak()
    {
        Console.WriteLine("Hello");

    }
    public class Dog : Animal
    {
        double wings;
        public Dog(string name, int age, int legs, double wings) : base(name, age, legs) 
        {
            this.wings = wings;
        }
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
