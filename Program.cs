// See https://aka.ms/new-console-template for more information

/* Parallel lINQ
- Programing in C# - Exam Ref 70 - 483, Microsoft, Rob Miles, 2019
*/
using System;
using System.Linq;

class Program
{
    class Person
    {
        public string Name {get; set;}
        public string City {get; set;}
    }

    static void Main(string[] args)
    {
        Person [] people = new Person []
        {
        
            new Person {Name = "Alen", City = "Hull"},
            new Person {Name = "Beryl", City = "Seattle"},
            new Person {Name = "Charles", City = "London"},
            new Person {Name = "David", City = "Seattle"},
            new Person {Name = "Eddy", City = "Paris"},
            new Person {Name = "Fred", City = "Berlin"},
            new Person {Name = "Gordon", City = "Hull"},
            new Person {Name = "Henry", City = "Seattle"},
            new Person {Name = "Isaac", City = "Seattle"},
            new Person {Name = "James", City = "London"}
        };

        var result = from person in people.AsParallel()
        where person.City == "Seattle" select person;

        foreach (var person in result)
        Console.WriteLine(person.Name);     


        Console.WriteLine("Finished processing. Press a key to end.");
        Console.ReadKey();
    }
}

