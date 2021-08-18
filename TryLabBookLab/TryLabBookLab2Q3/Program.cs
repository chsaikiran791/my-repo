using System;

namespace TryLabBookLab2Q3
{
    struct Program
    {
        static void Main(string[] args)
        {
            string[] a = new string[10];
            int count = 0;
            do
            {
                Console.WriteLine("1.add city");
                Console.WriteLine("2.display all cities");
                Console.WriteLine("3.exit");
                Console.WriteLine("enter choice");
                int ch = int.Parse(Console.ReadLine());
                switch(ch)
                {
                    case 1:
                        Console.WriteLine("enter city");
                        a[count] = Console.ReadLine();
                        count++;
                        break;
                    case 2:
                        for(int i=0;i<count;i++)
                        {
                            Console.WriteLine(a[i]);
                        }
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Invalid Entry");
                        break;
                }
            }
            while (true);
        }
    }
}
