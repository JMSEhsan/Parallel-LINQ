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
            new Person {Name = "Charles", City = "London"}
        };

            var result = from person in people.AsParallel()
            where person.City == "Seattle" select person;
        

    }
    
}

