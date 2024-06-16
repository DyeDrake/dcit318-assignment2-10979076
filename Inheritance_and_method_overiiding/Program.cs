using System;
using System.Media;

namespace OOPConcept
{
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Generic sound goes here!");
        }
        
    }

    class Dog : Animal
    { 
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    class Program
    {
        static void Main(String[] args)
        {
            Animal genAnimal = new Animal();

            Dog dog = new Dog();

            Cat cat = new Cat();
            
            cat.MakeSound();
            dog.MakeSound();
            genAnimal.MakeSound();
        }
    }
}

