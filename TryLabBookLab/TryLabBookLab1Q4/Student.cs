using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryLabBookLab1Q4
{
    class Student
    {
        public int rollno;
        public string name;
        public int age;
        public char gender;
        public string address;
        public double percentage;
        public void details()
        {
            Console.WriteLine("enter rollnumber");
            rollno = int.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            name = Console.ReadLine();
            Console.WriteLine("enter age");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("enter gender");
            gender = char.Parse(Console.ReadLine());
            Console.WriteLine("enter address");
            address = Console.ReadLine();
            Console.WriteLine("enter percentage");
            percentage = double.Parse(Console.ReadLine());
        }
        public void alter()
        {

        }
    }
}
