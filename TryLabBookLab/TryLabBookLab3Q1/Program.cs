using System;
/// <summary>
/// EmpId, Name, Company Name, FoundationMarks, WebBasicMarks, DotNetMarks, Total Marks, ObtainedMarks, Percentage
/// </summary>
namespace TryLabBookLab3Q1
{
    public class Employee
    {
        public int id;
        public string name;
        public static string cmpname;
        public double fmarks;
        public double wbmarks;
        public double dnmarks;
        public double tmarks;
        public double omarks;
        public double percentage;
        public Employee()
        {
            tmarks = 300;
        }
        static Employee()
        {
            cmpname = "Capgemini";
        }
        public Employee(int id,string name,double fmarks,double wbmarks,double dnmarks)
        {
            this.id = id;
            this.name = name;
            this.fmarks = fmarks;
            this.wbmarks = wbmarks;
            this.dnmarks = dnmarks;
        }
        public double obtmarksmethod(double fmarks,double wbmarks,double dnmarks)
        {
            omarks= fmarks + wbmarks + dnmarks;
            return omarks;
        }
        public double percentageM(double omarks)
        {
            percentage = (omarks / 300) * 100;
            return percentage;
        }
        public void showpercentage()
        {
            Console.WriteLine("percentage:"+percentage);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter id");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            string name = Console.ReadLine();
            Console.WriteLine("enter foundation marks");
            double fmarks = double.Parse(Console.ReadLine());
            Console.WriteLine("enter webbasic marks");
            double wbmarks = double.Parse(Console.ReadLine());
            Console.WriteLine("enter dotnet marks");
            double dnmarks = double.Parse(Console.ReadLine());
            Employee obj = new Employee(id, name, fmarks, wbmarks, dnmarks);
            obj.percentageM(obj.obtmarksmethod(fmarks, wbmarks, dnmarks));
            obj.showpercentage();
            
        }
    }
}
