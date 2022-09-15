using System;
using System.Linq;

namespace IDovhyiHomework4
{
    /*
  Define class Person. Class Person should consist of:
    a) two private fields: name and birthYear(the birthday year).
      (As a type for this field you may use DataTime type.)
    b) two properties for access to these fields(can use only get)
    c) default constructor and constructor with 2 parameters
    d) methods: - Age() - to calculate the age of person
            - Input() - to enter data about person from console
            - ChangeName() - to change the name of person
            - ToString()
            - Output() - to output information about person(call ToString())
            - operator== (equal by name)
*/
    internal class Person
    {
        private string name;
        private DateTime birthYear;
        public string Name
        {
            get { return name; }
        }
        public DateTime BirthYear
        { 
            get { return birthYear; }
        }

        public Person()
        {
            name = "Unnamed";
            birthYear = DateTime.Now;
        }
        public Person(string name, DateTime year)
        {
            this.name = name;
            this.birthYear = year;
        }

        public int Age()
        {
            return (DateTime.Now.Year - this.birthYear.Year);
        }
        public static Person Input(int i)
        {
            Console.Write($"Enter {i + 1} person name: ");
            string name = Console.ReadLine();
            Console.Write($"Enter {i + 1} person birth year: ");
            int year = int.Parse(Console.ReadLine());
            DateTime birthYear = new DateTime(year, 1, 1 );
            Person person = new Person(name, birthYear);
            return person;
        }
        public void ChangeName(string newName)
        {
            name = newName;
        }
        public override string ToString()
        {
            return "Persone name " + name + " birth year " + birthYear.Year;
        }
        public void Output(int i)
        {
            Console.WriteLine("Persone "+(i+1)+"- name : " + name + ",  birth year : " + birthYear.Year);
        }
        public static bool operator == (Person first, Person second)
        {
            return (first.name == second.name);
        }
        public static bool operator != (Person first, Person second)
        {
            return  !(first.name == second.name);
        }

    }
}
