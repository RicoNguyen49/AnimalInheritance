using System;

namespace Inheritance
{
    // base Class 
    class Animal
    {
        private string name; // only accessible within this class
        protected string type; //accessible from derived classes
        public string color;  // accessible from any class

        public void setName(string name)
        {
            this.name = name;
        }
        public virtual string getName()
        {
            return this.name;
        }
        public void setType(string type)
        {
            this.type = type;
        }
        public virtual string getType()
        {
            return this.type;
        }
    }
    // derived class 
    class Dog : Animal
    {
        public double weight;  // accessible from any class
        private int age;  //accessible from derived classes
        private int height;

        // Constructors
        public Dog()
        {
            age = 0;
            weight = 0;
            height = 0;
        }

        public void setAge(int age)
        {
            this.age = age;
        }
        public virtual int getAge()
        {
            return age;
        }
        public void setHeight(int height)
        {
            this.height = height;
        }
        public virtual int getHeight()
        {
            return height;
        }


        // access name through base because it is private
        public override string getName()
        {
            return base.getName();
        }

        // access type directly because it is protected and this is a derived class
        public override string getType()
        {
            return type;
        }


    }
    class Program
    {

        static void Main(string[] args)
        {
            // object of the base class Animal
            Animal critter = new Animal();
            critter.setName("steve");
            critter.setType("pig");
            // color is a public field and can be accessed anywhere
            critter.color = "pink";

            Console.WriteLine("Animal Information...");
            Console.WriteLine($"name:{critter.getName()}");
            Console.WriteLine($"Type:{critter.getType()}");
            Console.WriteLine($"Color: {critter.color} color");
            Console.WriteLine();

            // object of derived class Dog
            Dog puppy = new Dog();
            puppy.setName("tido");
            puppy.setType("dog");
            puppy.color = "black and white";
            // breed is a public field
            puppy.weight = 15;
            // age is a protected field
            puppy.setAge(2);
            puppy.setHeight(30);

            Console.WriteLine("Dog Information...");
            Console.WriteLine($"Name:{puppy.getName()}");
            Console.WriteLine($"Type:{puppy.getType()}");
            Console.WriteLine($"Color:{puppy.color} color");
            Console.WriteLine($"Age:{puppy.getAge()} years old");
            Console.WriteLine($"Weight: {puppy.weight}lb");
            Console.WriteLine($"Height: {puppy.getHeight()} inches");

            Console.ReadLine(); // pauses end of program display
        }

    }
}