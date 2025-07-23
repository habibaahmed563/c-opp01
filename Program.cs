namespace c_opp01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //part 01 : 
            //1. 


            Console.WriteLine("enter point 1 :");
            double X1 = double.Parse(Console.ReadLine());
            double Y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("enter point 2 : ");
            double X2 = double.Parse(Console.ReadLine());
            double Y2 = double.Parse(Console.ReadLine());

            Point P1 = new Point(X1, Y1);
            Point P2 = new Point(X2, Y2);
            double distance = P1.distance(P2);

            /*=========================================================*/

            //2. 

            Console.WriteLine("enter the name of the first person");
            string name1 = Console.ReadLine();
            Console.WriteLine("enter the age for the first person ");
            int age1 = int.Parse(Console.ReadLine());


            Console.WriteLine("enter the name of the second person");
            string name2 = Console.ReadLine();
            Console.WriteLine("enter the age for the second person ");
            int age2 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the name of the third person");
            string name3 = Console.ReadLine();
            Console.WriteLine("enter the age for the third person ");
            int age3 = int.Parse(Console.ReadLine());

            Person p1 = new Person(name1, age1);
            Person p2 = new Person(name2, age2);
            Person p3 = new Person(name3, age3);

            Person oldest = p1;
            if (p2.Age> oldest.Age)
            {
                oldest = p2;
            }
            if (p3.Age> oldest.Age)
            {
                oldest = p3;
            }

            Console.WriteLine($"the oldest person is : {oldest.Name} whos's age is : {oldest.Age}");

            /*=================================================================*/

            //part 02: 

            Employee[] Emparr = new Employee[3];

        }
    }
}
