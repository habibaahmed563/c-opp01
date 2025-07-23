namespace c_opp01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task

            zoo[] zoos = new zoo[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("enter the name of zoo :", i + 1);
                zoos[i].Name = Console.ReadLine();

                Console.WriteLine("enter number of animals ", zoos[i].Name);
                zoos[i].animalcount = int.Parse(Console.ReadLine());
            }


            int maxIndex = 0;
            for (int i = 1; i < 3; i++)
            {
                if (zoos[i].animalcount > zoos[maxIndex].animalcount)
                    maxIndex = i;
            }

            Console.WriteLine($"the name of the zoo with the max animals {zoos[maxIndex].Name} ");
            Console.WriteLine($"the animal count {zoos[maxIndex].animalcount}"); 
            #endregion


            /* -------------------------------------------------------------------------*/

            //demo : 


            #region struct
            //struct :value type : stack 

            //employee
            //id , name , salary 

            //point 
            point P01;
            //declare for object from type 'point'
            //P01 : object 
            //allocate uninitialized 8 bytes at stack 

            //Console.WriteLine(P01.x);
            //Console.WriteLine(P01.y);

            //P01.x = 12;
            //P01.y = 12;

            //Console.WriteLine(P01.x);
            //Console.WriteLine(P01.y);

            P01 = new point();
            // new : used for select the constructor 

            //Console.WriteLine(P01.x);
            //Console.WriteLine(P01.y);

            //Console.WriteLine(P01); 

            //P01.printpoint();

            //Console.WriteLine(P01.ToString()); 
            #endregion

            #region OOP overview 
            // oop : object oriented programming 
            // programing paradigm 
            // oop : the paradigm use for build any business 

            //class : blueprint of the object 
            // object : specific instance from class 

            //4. pillars 
            //===================
            //1. encapsulation 
            //2. inheritance 
            //3. ploymorphism 
            //4. abstraction  
            #endregion

            #region encapsulation 

            //1. encapsulation : 
            // class or struct 
            // seperate the data(attributes) definition from its use 
            //[setter getter method - properties]

            // employee 
            // id , name , salary 

            //1. end user access data itself 
            //2. no data validation 
            //3. no read only filed 

            //apply encapsulation : 
            //make all data(attributes) private 
            //2. access data through : 
            //2.1.setter getter method 
            //2.1.properties

            //employee E01 = new employee(1, "ahmed", -12000);
            //Console.WriteLine(E01);

            //id : read only attributes 


            //E01.id = 1;
            //E01.name = "ahmed";
            //E01.salary = 12000;

            //Console.WriteLine(E01.id);
            //Console.WriteLine(E01.name);
            //Console.WriteLine(E01.salary);

            //E01.setid(1);
            //E01.setname("ahmed");
            //E01.setsalary(12000);

            //Console.WriteLine(E01.getid());
            //Console.WriteLine(E01.getname());
            //Console.WriteLine(E01.getsalary());

            //Console.WriteLine(E01);

            employee E01 = new employee();

            E01.Id = 12;
            E01.Name = "ahmed";
            E01.Salary = 12000;
            E01.Address = "cairo";



            Console.WriteLine(E01.Id);
            Console.WriteLine(E01.Name);
            Console.WriteLine(E01.Salary);
            Console.WriteLine(E01.Address);
            #endregion

            #region Indexer
            //Indexer : special property 

            //phonebook 

            phonebook phonebook = new phonebook(3);

            phonebook.Addperson("Ahmed", 111, 0);
            phonebook.Addperson("Ali", 222, 1);
            phonebook.Addperson("omar", 333, 2);

            //Console.WriteLine(phonebook.Getnumber("ahmed"));

            //phonebook.updatenumbers("ahmed", 999);

            //Console.WriteLine(phonebook.Getnumber("ahmed")); 
            #endregion

            //class : reference types : Heap 

            //car : id , model , speed 

            car c01;
            //declare for reference (pointer) from type 'car'
            //C01 : can refer to object from type 'car 'or any class inherited from car\
            // C01 : refer to null

            //Console.WriteLine(c01);

            //8 bytes will be allocated at stack for the reference 'C01'
            //0 bytes will be allocated at Heap


            c01 = new car();
            //new 
            //1. allocate the number of required bytes at heap for the object 
            //2.initialized the allocated bytes with the default value of the datatypes
            //3. call user-defined constructor if exists 
            //4. assign the object to the reference 

            //Console.WriteLine(c01.Id);
            //Console.WriteLine(c01.Model);
            //Console.WriteLine(c01.Speed);

            Console.WriteLine(c01);


        }
    }
}
