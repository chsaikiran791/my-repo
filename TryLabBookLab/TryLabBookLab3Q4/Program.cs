using System;

namespace TryLabBookLab3Q4
{
    class Supplier
    {
        public int id;
        public string name;
        public string city;
        public string phno;
        public string email;
        public void getdetails()
        {
            Console.WriteLine("enter id");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            name = Console.ReadLine();
            Console.WriteLine("enter city");
            city = Console.ReadLine();
            Console.WriteLine("enter phno");
            phno = Console.ReadLine();
            Console.WriteLine("enter email");
            email = Console.ReadLine();
        }
        public void showdetails()
        {
            Console.WriteLine("id:{0}\nname:{1}\ncity:{2}\nphno:{3}\nemail:{4}", id, name, city, phno, email);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Supplier supplier = new Supplier();
            supplier.getdetails();
            supplier.showdetails();
        }
    }
}
