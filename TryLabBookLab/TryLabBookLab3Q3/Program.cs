using System;
//make, model, year, and sale price.
namespace TryLabBookLab3Q3
{
    class Car
    {
        public string year;
        public string model;
        public string make;
        public string price;
        public void adddetails()
        {
            Console.WriteLine("enter make");
            make = Console.ReadLine();
            Console.WriteLine("enter model");
            model = Console.ReadLine();
            Console.WriteLine("enter year");
            year = Console.ReadLine();
            Console.WriteLine("enter price");
            price = Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car obj = new Car();
            string[,] a = new string[10, 4];
            int count = 0;
            do
            {
                Console.WriteLine("1.enter car details");
                Console.WriteLine("2.display all car details");
                Console.WriteLine("3.modify the car details based on year");
                Console.WriteLine("4.search for a particular car");
                Console.WriteLine("5.delete a car's details");
                Console.WriteLine("6.exit");
                Console.WriteLine("enter your choice");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        {
                            obj.adddetails();
                            for(int i=count;i<=count;i++)
                            {
                                for(int j=0;j<4;j++)
                                {
                                    if(j==0)
                                    {
                                        a[i, j] = obj.make;
                                    }
                                    else
                                        if(j==1)
                                    {
                                        a[i, j] = obj.model;
                                    }
                                    else
                                        if(j==2)
                                    {
                                        a[i, j] = obj.year;
                                    }
                                    else
                                    {
                                        a[i, j] = obj.price;
                                    }
                                }
                            }
                            count++;
                            break;
                        }
                    case 2:
                        {
                            for(int i=0;i<count;i++)
                            {
                                for(int j=0;j<4;j++)
                                {
                                    Console.Write(a[i, j]+" ");
                                }
                                Console.WriteLine();
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("enter year");
                            string year = Console.ReadLine();
                            for(int i=0;i<count;i++)
                            {
                                for(int j=2;j<=2;j++)
                                {
                                    if(a[i,j]==year)
                                    {
                                        Console.WriteLine("1.modify make\n2.modify model\n3.modify year\n4.modify price");
                                        Console.WriteLine("enter choice");
                                        int ch1 = int.Parse(Console.ReadLine());
                                        switch(ch1)
                                        {
                                            case 1:
                                                {
                                                    Console.WriteLine("enter the new make");
                                                    string make1 = Console.ReadLine();
                                                    a[i, 0] = make1;
                                                    break;
                                                }
                                            case 2:
                                                {
                                                    Console.WriteLine("enter the new model");
                                                    string model1 = Console.ReadLine();
                                                    a[i, 1] = model1;
                                                    break;
                                                }
                                            case 3:
                                                {
                                                    Console.WriteLine("enter the new year");
                                                    string year1 = Console.ReadLine();
                                                    a[i, 2] = year1;
                                                    break;
                                                }
                                            case 4:
                                                {
                                                    Console.WriteLine("enter the new price");
                                                    string price1 = Console.ReadLine();
                                                    a[i, 3] = price1;
                                                    break;
                                                }
                                            default:
                                                {
                                                    Console.WriteLine("Invalid Entry");
                                                    break;
                                                }
                                        }
                                    }
                                }
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.Write("enter year");
                            string year = Console.ReadLine();
                            for(int i=0;i<count;i++)
                            {
                                for(int j=2;j<=2;j++)
                                {
                                    if(a[i,j]==year)
                                    {
                                        for(int m=i;m<=i;m++)
                                        {
                                            for(int n=0;n<4;n++)
                                            {
                                                Console.Write(a[m, n] + " ");
                                            }
                                            Console.WriteLine();
                                        }
                                    }
                                }
                            }
                            break;
                        }
                    case 5:
                        {
                            Console.Write("enter year to delete");
                            string year2 = Console.ReadLine();
                            for(int i=0;i<count;i++)
                            {
                                for(int j=2;j<=2;j++)
                                {
                                    if(a[i,j]==year2)
                                    {
                                        for(int m=i;m<=i;m++)
                                        {
                                            for(int n=0;n<4;n++)
                                            {
                                                a[m, n] = null;
                                            }
                                        }
                                    }
                                }
                            }
                            break;
                        }
                    case 6:
                        {
                            return;
                        }
                    default:
                        {
                            Console.Write("Invalid Entry");
                            break;
                        }
                }

            }
            while (true);
        }
    }
}
