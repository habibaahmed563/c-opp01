namespace c_opp01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            zoo[] zoos = new zoo[3];

            for (int i = 0;i < 3;i++)
            {
                Console.WriteLine("enter the name of zoo :", i + 1);
                zoos[i].Name = Console.ReadLine();

                Console.WriteLine("enter number of animals ", zoos[i].Name);
                zoos[i].animalcount = int.Parse(Console.ReadLine());
            }


            int maxIndex= 0;
            for (int i =1;i<3;i++)
            {
                if (zoos[i].animalcount > zoos[maxIndex].animalcount)
                    maxIndex = i;
            }

            Console.WriteLine($"the name of the zoo with the max animals {zoos[maxIndex].Name} ");
            Console.WriteLine($"the animal count {zoos[maxIndex].animalcount}");



        }
    }
}
