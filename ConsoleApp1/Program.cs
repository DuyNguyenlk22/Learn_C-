using System;

namespace learning
{
    internal class Program
    {
        class Animal
        {
            protected double Height;
            protected double Weight;
            protected int Legs;

            public Animal(double height, double weight, int legs)
            {
                Height = height;
                Weight = weight;
                Legs = legs;
            }

            public void Info()
            {
                Console.WriteLine("Height : " + Height + " Weight : " +  Weight + " Legs : " + Legs);
            }
        }
        class Cat : Animal
        {
            public Cat(double height, double weight, int legs) : base(height, weight, legs)
            {
                
            }   
        }
        static void Main(string[] args)
        {
            Cat blackCat = new Cat(15,3,4);
            blackCat.Info();
            Console.WriteLine("Hello C#");
            Console.ReadKey();
        }
    }
}