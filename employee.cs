namespace c_opp01
{
    internal struct employee
    {
        private int id;
        private string name;
        private double salary;
        private string address;

        //address

        #region apply encapsulation user setter getter method
        // apply encapsulation user setter getter method 

        //setter 

        //public void setid(int id)
        //{
        //    this.id = id;
        //}
        //getter 
        public int getid()
        {
            return id;
        }

        //setter name 
        public void setname(string name)
        {
            if (name.Length >= 8 && name.Length <= 20)
                this.name = name;
        }

        //getter
        public string getname()
        {
            return name;
        }

        public void setsalary(double salary)
        {
            if (salary > 0)
                this.salary = salary;
        }

        public double getsalary()
        {
            return salary;
        }




        public employee(int id, string name, double salary)
        {
            //setid(id);
            setname(name);
            setsalary(salary);
        }

        public override string ToString()
        {
            return $"id : {id} :: name : {name} :: salary : {salary}";
        }
        #endregion


        //apply encapsulation user properties : 
        //1. full property 


        //id 
        public int Id
        {
            //set
            //get
            set
            {
                id = value;
            }
            get
            {
                return id;
            }
        }

        //name 
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }

        public double Salary
        {
            set
            {
                salary = value;
            }
            get
            {
                return salary;
            }
        }



        public string Address
        {
            set
            {
                address = value;
            }
            get
            {
                return address;
            }
        }


        //2. automatic property 


        //public string Address { set; get }


        //3. special property [indexer]

      



    }
}
