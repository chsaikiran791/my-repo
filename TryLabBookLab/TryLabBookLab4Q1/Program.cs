using System;

namespace TryLabBookLab4Q1
{
    class Employee
    {
        private int Id;
        private string Name;
        private string Address;
        private string City;
        private string Dept;
        private double Sal;

        public int Id1 { get => Id; set => Id = value; }
        public string Name1 { get => Name; set => Name = value; }
        public string Address1 { get => Address; set => Address = value; }
        public string City1 { get => City; set => City = value; }
        public string Dept1 { get => Dept; set => Dept = value; }
        public virtual double Sal1 { get => Sal; set => Sal = value; }
    }
    class contractEmployee : Employee
    {
        public double perks;
        public override double Sal1 { get => base.Sal1 + perks; set => base.Sal1 = value; }
    }
    class permanentEmployee : Employee
    {
        public double pf;
        public override double Sal1 { get => base.Sal1 - pf; set => base.Sal1 = value; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.temporary\n2.permanent");
            int ch = int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    {
                        contractEmployee cemp = new contractEmployee();
                        Console.Write("enter id");
                        cemp.Id1 = int.Parse(Console.ReadLine());
                        Console.Write("enter name");
                        cemp.Name1 = Console.ReadLine();
                        Console.WriteLine("enter address");
                        cemp.Address1 = Console.ReadLine();
                        Console.WriteLine("enter city");
                        cemp.City1 = Console.ReadLine();
                        Console.WriteLine("enter dept");
                        cemp.Dept1 = Console.ReadLine();
                        Console.WriteLine("enter salary");
                        cemp.Sal1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("enter perks amount");
                        cemp.perks = double.Parse(Console.ReadLine());
                        Console.WriteLine("total salary:" + cemp.Sal1);
                        break;
                    }
                case 2:
                    {
                        permanentEmployee pemp = new permanentEmployee();
                        Console.Write("enter id");
                        pemp.Id1 = int.Parse(Console.ReadLine());
                        Console.Write("enter name");
                        pemp.Name1 = Console.ReadLine();
                        Console.WriteLine("enter address");
                        pemp.Address1 = Console.ReadLine();
                        Console.WriteLine("enter city");
                        pemp.City1 = Console.ReadLine();
                        Console.WriteLine("enter dept");
                        pemp.Dept1 = Console.ReadLine();
                        Console.WriteLine("enter salary");
                        pemp.Sal1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("enter pf amount");
                        pemp.pf = double.Parse(Console.ReadLine());
                        Console.WriteLine("total salary:" + pemp.Sal1);
                        break;
                    }
            }


        }
    }
}
