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

        }
    }
}
