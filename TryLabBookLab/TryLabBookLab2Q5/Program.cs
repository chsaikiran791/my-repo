using System;

namespace TryLabBookLab2Q5
{
    class BookDetails
    {
        public string title;
        public string author;
        public string publisher;
        public string price;
        public void getdetails()
        {
            Console.WriteLine("enter title");
            title = Console.ReadLine();
            Console.WriteLine("enter author");
            author = Console.ReadLine();
            Console.WriteLine("enter publisher");
            publisher = Console.ReadLine();
            Console.WriteLine("enter price");
            price = Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BookDetails obj = new BookDetails();
            string[,] a = new string[10, 4];
            int count = 0;
            do
            {
                Console.WriteLine("1.enter details");
                Console.WriteLine("2.display all book details");
                Console.WriteLine("3.exit");
                Console.WriteLine("enter choice");
                int ch = int.Parse(Console.ReadLine());
                switch(ch)
                {
                    case 1:
                        {
                            obj.getdetails();
                            for (int i = count; i <=count; i++)
                            {
                                for (int j = 0; j < 4; j++)
                                {
                                    if (j == 0)
                                    {
                                        a[i, j] = obj.title;
                                    }
                                    else
                                        if (j == 1)
                                    {
                                        a[i, j] = obj.author;
                                    }
                                    else
                                        if (j == 2)
                                    {
                                        a[i, j] = obj.publisher;
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
                            for(int i=0;i<=count;i++)
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
                        return;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;

                }
            }
            while (true);
        }
    }
}
