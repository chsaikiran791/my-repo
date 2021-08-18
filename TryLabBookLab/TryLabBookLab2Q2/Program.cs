using System;

namespace TryLabBookLab2Q2
{
    struct Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[2, 3];
            Console.WriteLine("enter the elements in the array");
            for(int i=0;i<2;i++)
            {
                for(int j=0;j<3;j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for(int i=0;i<2;i++)
            {
                for(int j=0;j<3;j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
