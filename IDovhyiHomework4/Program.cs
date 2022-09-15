using System;
using System.Linq;


namespace IDovhyiHomework4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.In the method Main() create 6 objects of Person type and enter information about them.
            Person[] people = new Person[5];
            for (int i = 0; i < people.Length; i++) people[i] = Person.Input(i);
            Console.WriteLine();

            // 2.Then calculate and output on the console name and Age of each person;
            Console.WriteLine("Name and Age of each person");
            for (int i = 0; i < people.Length; i++) Console.WriteLine("Persone " + (i + 1) + " - name: " + people[i].Name + ",  Age: " + people[i].Age());
            Console.WriteLine();

            // 3.Change the name of persons, which Age is less then 16, to "Very Young".
            for (int i = 0; i < people.Length; i++) if (people[i].Age() < 16) people[i].ChangeName("Very Young");

            // 4.Output information about all persons on the console.
            Console.WriteLine("Information about all personse");
            for (int i = 0; i < people.Length; i++) people[i].Output(i);
            Console.WriteLine();

            // 5.Find and output information about Persons with the same names(use ==).
            Console.WriteLine("Persons with the same name");
            Person[] people2 = people.Where(x => people.Count(y => x == y) > 1).ToArray();
            foreach (Person person in people2) Console.WriteLine(person);
        }
    }
}
