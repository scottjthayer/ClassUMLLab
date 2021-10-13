using System;
using System.Collections.Generic;
using System.Text;

namespace Class_UML_Lab
{
    class Student:Person
    {
        public string Program { get; set; }
        public int Year { get; set; }
        public double Fee { get; set; }


        public Student(string name, string address, string program, int year, double fee):base(name, address)
        {
            Program = program;
            Year = year;
            Fee = fee;
        }
        public Student():base()
        {       
            Program = "";
            Year = 0;
            Fee = 0;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Program = {Program}, Year = {Year}, Fee = {Fee}";
        }
    }
}
