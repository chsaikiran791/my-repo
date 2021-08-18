using System;

namespace LabBookLab1Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter no");
            int a = int.Parse(Console.ReadLine());
            switch(a)
            {
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                default:
                    Console.WriteLine("Invalid Entry");
                    break;
            }
        }
    }
}
