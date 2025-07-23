using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_opp01
{
    internal class car
    {
        //Id 

        #region attributes
        private int id;
        private int speed;
        private string model;
        #endregion

        #region properties
        public string Model
        {
            get { return Model; }
            set { Model = value; }
        }


        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        #endregion

        // CLR will generate parameterless constructor 
        //this constructor do nothing 

        //ctor


        //public car()
        //{
                
        //} //do nothing 

        //public car()
        //{
        //    Id = default;
        //    speed = default;
        //    model= default;
        //}


        public override string ToString()
        {
            return $"id: {id} :: speed {Speed} :: model : {Model}";
        }

    }
}
