using System;

namespace TryLabBookLab1Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                
                Console.WriteLine("1.add");
                Console.WriteLine("2.subtract");
                Console.WriteLine("3.multiply");
                Console.WriteLine("4.divide");
                Console.WriteLine("5.Exit");
                Console.WriteLine("enter choice of operation");
                int ch = int.Parse(Console.ReadLine());
                Console.WriteLine("enter a");
                int a = int.Parse(Console.ReadLine());
                
                Console.WriteLine("enter b");
                int b = int.Parse(Console.ReadLine());
                Calculator obj = new Calculator();
                switch(ch)
                {
                    case 1:
                        {
                            Console.WriteLine(obj.sum(a, b));
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine(obj.diff(a, b));
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine(obj.pro(a, b));
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine(obj.rem(a, b));
                            break;
                        }
                    case 5:
                        {
                            return;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid Entry");
                            break;
                        }
                }
            }
            while (true);
        }
    }
}
