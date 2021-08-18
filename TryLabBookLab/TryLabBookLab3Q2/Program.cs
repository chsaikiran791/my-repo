using System;

namespace TryLabBookLab3Q2
{
    class Bird
    {
        public string Name;
        public double MaxHeight;
        public Bird()
        {
            Name = "Mountain Eagle";
            MaxHeight = 500;
        }
        public Bird(string Name,double MaxHeight)
        {
            this.Name = Name;
            this.MaxHeight = MaxHeight;
        }
        public void fly()
        {
            Console.WriteLine("{0} is flying at altitude of {1}", this.Name, this.MaxHeight);
        }
        public void fly(double atHeight)
        {
            if(atHeight<=MaxHeight)
            {
                Console.WriteLine("{0} can fly at {1} height", Name, atHeight);
            }
            else
            {
                Console.WriteLine("{0} cannot fly at {1} altitude", Name, atHeight);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bird o = new Bird("Eagle", 200);
            o.fly();
            o.fly(300);
        }
    }
}
