using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_opp01
{

    enum securitylevel
    {
        guest,
        developer,
        secretary,
        DBA,
        securityofficer
    }


    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public char Gender
        {
            set
            {
                if (value == 'M' || value == 'F')
                    Gender = value;
                else
                    Console.WriteLine("invalid gender");
            }
            get
            {
                return Gender;
            }
        }
        
        public double salary { get; set; }
        public DateOnly hiringdate { get; set; }
        public int securityLevel { get; set; }


        public Employee(int id, int name, char gender, double salary, DateOnly hiringdate, int securityLevel)
        {
            Id = id;
            Name = name;
            Gender = gender;
            this.salary = salary;
            this.hiringdate = hiringdate;
            this.securityLevel = securityLevel;
        }

        public override string ToString()
        {
            return $"Id: {Id}:: name : {Name}::Gender : {Gender}::salary :{salary}::hiringdate : {hiringdate: dd/mm/yyy}::sacuritylevel: {securityLevel}";
        }



    }
}
