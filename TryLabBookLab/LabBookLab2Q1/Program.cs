using System;

namespace TryLabBookLab2Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a");
            int a = int.Parse(Console.ReadLine());
            Number obj = new Number(a);
            Console.WriteLine("square of a:{0}\ncube of a:{1}", obj.square(a), obj.cube(a));
        }
    }
}
