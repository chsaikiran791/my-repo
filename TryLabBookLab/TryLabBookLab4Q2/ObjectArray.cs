using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryLabBookLab4Q2
{
    class student
    {
        public string name;
        public int id;
    }
    class ObjectArray
    {
        static void Main()
        {
            student[] a = new student[3];
            a[1] = new student();
            for(int i=0;i<3;i++)
            {
                a[i] = new student();
                Console.WriteLine("enter name");
                a[i].name = Console.ReadLine();
                Console.WriteLine("enter id");
                a[i].id = int.Parse(Console.ReadLine());
            }
            for(int i=0;i<3;i++)
            {
                Console.WriteLine("{0} {1}", a[i].name, a[i].id);
            }
        }
    }
}
