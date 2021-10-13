using System;
using System.Collections.Generic;
using Validator;
namespace Class_UML_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
                { new Student("David Cho", "333 Houseman Rd", "Business Administration", 2, 10000 ) },
                { new Student("Martha Keller", "1349 Lovelace Ave", "Computer Science", 1, 14000) },
                { new Student("Damien Lopez", "412 4th St", "Marketing and Advertising", 4, 23500) },
                { new Staff("Marcus Aurelius", "952 32nd St", "Business", 85000) },
                { new Staff("Lorde Yontell", "21 Main St", "Engineering", 87500) },
            };

            foreach (Person p in people)
            {
                Console.WriteLine(p);
            }
            
            bool run = Validator.Validator.GetContinue("Would you like to add some to this list?");
            while (run == true)
            {             
                
                ExtraPerson(people);
                foreach (Person p in people)
                {
                    Console.WriteLine(p);
                }
                run = Validator.Validator.GetContinue("Would you like to add some to this list?");
            }
            Console.WriteLine("Thank you for looking at our student/staff list!");
        }

        public static List<Person> ExtraPerson(List<Person> people)
        {
            Console.WriteLine("Is the person you are adding a student or a staff?");
            string stuSta = Console.ReadLine();
            Console.WriteLine("What is the person's name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is the person's address?");
            string address = Console.ReadLine();
            Console.WriteLine("What is their program or school?");
            string proSch = Console.ReadLine();
            Console.WriteLine("What year is the student in? Enter 0 if staff.");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("What is their fee? Enter 0 if staff.");
            double fee = double.Parse(Console.ReadLine());
            Console.WriteLine("What is their pay? Enter 0 if student.");
            double pay = double.Parse(Console.ReadLine());

            if (stuSta == "student")
            {
                people.Add(new Student(name, address, proSch, year, fee));
            }
            else if (stuSta == "staff")
            {
                people.Add(new Staff(name, address, proSch, pay));
            }

            return people;
        }
    }
}
