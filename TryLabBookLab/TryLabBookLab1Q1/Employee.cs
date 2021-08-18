//EmployeeId, Employee Name, Address, City, Department, Salary
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryLabBookLab1Q1
{
    class Employee
    {
        public int Id;
        public string Name;
        public string Address;
        public string City;
        public string Dept;
        public double Sal;

        /*public Employee(int id, string name, string address, string city, string dept, double sal)
        {
            Id = id;
            Name = name;
            Address = address;
            City = city;
            Dept = dept;
            Sal = sal;
        }*/

        public void getdetails()
        {
            Console.Write("enter id");
            Id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            Name = Console.ReadLine();
            Console.WriteLine("enter address");
            Address = Console.ReadLine();
            Console.WriteLine("enter city");
            City = Console.ReadLine();
            Console.WriteLine("enter dept");
            Dept = Console.ReadLine();
            Console.WriteLine("enter sal");
            Sal = double.Parse(Console.ReadLine());

        }
    }
}
