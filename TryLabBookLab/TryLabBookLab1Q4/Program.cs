using System;

namespace TryLabBookLab1Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rollarray = new int[10];
            string[] namearray = new string[10];
            int[] agearray = new int[10];
            char[] genarray = new char[10];
            string[] addarray = new string[10];
            double[] perarray = new double[10];
            int count = 0;
            do
            {
                Console.WriteLine("1.add details");
                Console.WriteLine("2.get all details");
                Console.WriteLine("3.exit");
                Console.WriteLine("enter choice");
                int ch = int.Parse(Console.ReadLine());
                Student obj = new Student();
                
                switch(ch)
                {
                    case 1:
                        {
                            obj.details();
                            rollarray[count] = obj.rollno;
                            namearray[count] = obj.name;
                            agearray[count] = obj.age;
                            genarray[count] = obj.gender;
                            addarray[count] = obj.address;
                            perarray[count] = obj.percentage;
                            count++;
                            break;
                        }
                    case 2:
                        {
                            for(int i=0;i<count;i++)
                            {
                                Console.WriteLine("{0} {1} {2} {3} {4} {5}", rollarray[i], namearray[i], agearray[i], genarray[i], addarray[i], perarray[i]);
                                Console.WriteLine("============================");
                            }
                            break;
                        }
                    case 3:
                        {
                            return;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid Entry");
                            break;
                        }
                }
            }
            while (true);
        }
    }
}
