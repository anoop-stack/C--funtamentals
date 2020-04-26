using System.Collections.Generic;

namespace ConstructorT
{
    public class Customers
    {
        private string Name;
        private int Id;
        /*
        every class has a constructor , it don't have a return type , constructor can be over loaded , mean we can have n number of constructor..  
        if we create constructr the complier will not create the default constructor
        */

        private List<int> list;
        //or 
        //  private List<int> list = new List<int>();
        //every time we don't need to create constructor only for insalization the list of othe class , if not it will give NullReferenaceException
        public Customers()// default constructor
        {
            //this is a constructor, same name as the class name

            list = new List<int>();

        }

        public Customers(string name)// :this() call default constructor
        : this()
        {
            this.Name = name;
            // this is a key word refers to the current object
        }

        public Customers(int id, string name)
        : this(name)
        {
            this.Id = id;
        }
    }
}
