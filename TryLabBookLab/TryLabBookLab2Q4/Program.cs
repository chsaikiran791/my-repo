using System;

namespace TryLabBookLab2Q4
{
    class Productdemo
    {
        public object productid;
        public object productname;
        public object price;
        public object quantity;
        public object payable;
        public void getdetails()
        {
            Console.WriteLine("enter product id");
            productid = Console.ReadLine();
            Console.WriteLine("enter product name");
            productname = Console.ReadLine();
            Console.WriteLine("enter price");
            price = Console.ReadLine();
            Console.WriteLine("enter quantity");
            quantity = Console.ReadLine();
        }
        public double amtpayable(double price,double quantity)
        {
            return price * quantity;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Productdemo obj = new Productdemo();
            obj.getdetails();
            double j1 = Convert.ToDouble(obj.price);
            double j2 = Convert.ToDouble(obj.quantity);
            Console.WriteLine("amount payable:"+obj.amtpayable(j1,j2));
        }
    }
}
