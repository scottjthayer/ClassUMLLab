using System;
using System.Collections.Generic;
using System.Text;

namespace Class_UML_Lab
{
    class Staff:Person
    {
        public string School { get; set; }
        public double Pay { get; set; }


        public Staff (string name, string address, string school, double pay):base(name, address)
        {
            School = school;
            Pay = pay;
        }
        public Staff():base()
        {         
            School = "";
            Pay = 0;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, School = {School}, Pay = {Pay}";
        }
    }
}
