using System;

interface IMovable
{
    void Move();
}

class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

class Bycicle : IMovable
{
    public void Move()
    {
        Console.WriteLine("Bycicle is moving");
    }
}

class Program
{
    static void Main(String[] args)
    {
        IMovable car = new Car();
        IMovable bycicle = new Bycicle();

        car.Move();
        bycicle.Move();

        Console.ReadLine(); 
    }
}
