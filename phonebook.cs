using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_opp01
{
    internal struct phonebook
    {
        string[] names;
        long[] numbers;

        public phonebook(int size)
        {
            names = new string[size];
            numbers = new long[size];
        }

        public void Addperson (string name,long number , int Index)
        {
            names[Index] = name;
            numbers[Index]= number;
        }

        public long Getnumber(string name)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name)
                    return numbers[i];
            }

            return -1;
        }


        public long updatenumbers (string name,long newnumber)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name)
                    numbers[i] = newnumber;
            }
            return -1;
        }
        


    }
}
