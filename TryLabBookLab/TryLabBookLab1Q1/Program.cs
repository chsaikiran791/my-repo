using System;

namespace TryLabBookLab1Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] idarray = new int[10];
            string[] namearray = new string[10];
            string[] addarray = new string[10];
            string[] cityarray = new string[10];
            string[] deptarray = new string[10];
            double[] salarray = new double[10];
            Employee obj = new Employee();
            for(int i=0;i<10;i++)
            {
                obj.getdetails();
                idarray[i] = obj.Id;
                namearray[i] = obj.Name;
                addarray[i] = obj.Address;
                cityarray[i] = obj.City;
                deptarray[i]=obj.Dept;
                salarray[i] = obj.Sal;
            }
            for(int i=0;i<10;i++)
            {
                Console.WriteLine("salary of{0} is {1}", namearray[i], salarray[i]);
            }
        }
    }
}
