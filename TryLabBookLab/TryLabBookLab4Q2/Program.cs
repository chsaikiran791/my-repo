using System;

namespace TryLabBookLab4Q2
{
    public class shape
    {
        public virtual void whoami()
        {
            Console.WriteLine("i am a shape");
        }
    }
    class circle:shape
    {
        public override void whoami()
        {
            Console.WriteLine("i am a circle");
        }

    }
    class triangle : shape
    {
        public override void whoami()
        {
            Console.WriteLine("i am a triangle");
        }

    }
    class test_shape
    {
        static void Main()
        {
            circle o1 = new circle();
            o1.whoami();
            triangle o2 = new triangle();
            o2.whoami();
        }
    }

}
