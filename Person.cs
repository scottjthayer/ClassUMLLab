using System;
using System.Collections.Generic;
using System.Text;

namespace Class_UML_Lab
{
    class Person
    {
        //properties
        public string Name { get; set; }
        public string Address { get; set; }
        
        //OUTDATED WAY
        //private string name;
        //public string Name
        //{
        //    get { return name; }
        //    set { this.name = value; }
        //}

        //constructor
        public Person (string name, string address)
        {
            Name = name;
            Address = address;
        }
        public Person()
        {
            Name = "";
            Address = "";
        }
        //methods
        public override string ToString()
        {
            return $"Name = {Name}, Address = {Address}";
        }


    }
}
