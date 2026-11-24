using System;
using System.Collections.Generic;
using System.Text;

namespace Packt.Shared
{
    public partial class Person
    {

        #region Properties

        public string? Name2 { get; set; }
        public DateTimeOffset Born2 { get; set; }

        public List<Person> Children2 { get; set; } = new();

        public List<Person> Spouses { get; set; } = new();

        public bool Married => Spouses.Count > 0;

        #endregion

        #region Methods

        public virtual void WriteToConsole() {

            WriteLine($"{Name2} was born on {Born2:dddd}.");
        }

        public void WriteChildrenTOConsole() { 
        
        string term=Children2.Count==1 ? "child" : "children";

            WriteLine($"{ Name2} has {Children2.Count} {term}.");


        }


        public static void Marry(Person p1, Person p2)
        {
            ArgumentNullException.ThrowIfNull(p1);
            ArgumentNullException.ThrowIfNull(p2);
            if (p1.Spouses.Contains(p2) || p2.Spouses.Contains(p1))
            {
                throw new ArgumentException(
                  string.Format("{0} is already married to {1}.",
                  arg0: p1.Name, arg1: p2.Name));
            }
            p1.Spouses.Add(p2);
            p2.Spouses.Add(p1);
        }

        // Instance method to marry another person.
        public void Marry(Person partner)
        {
            Marry(this, partner); // "this" is the current person.
        }

        public void OutputSpouses()
        {
            if (Married)
            {
                string term = Spouses.Count == 1 ? "person" : "people";
                WriteLine($"{Name} is married to {Spouses.Count} {term}:");
                foreach (Person spouse in Spouses)
                {
                    WriteLine($" {spouse.Name}");
                }
            }
            else
            {
                WriteLine($"{Name} is a singleton.");
            }
        }


        public static Person Procreate(Person p1, Person p2)
        {
            ArgumentNullException.ThrowIfNull(p1);
            ArgumentNullException.ThrowIfNull(p2);
            if (!p1.Spouses.Contains(p2) && !p2.Spouses.Contains(p1))
            {
                throw new ArgumentException(string.Format(
               "{0} must be married to {1} to procreate with them.",
      arg0: p1.Name, arg1: p2.Name));
            }
            Person baby = new()
            {
                Name = $"Baby of {p1.Name} and {p2.Name}",
                Born = DateTimeOffset.Now
            };
            p1.Children.Add(baby);
            p2.Children.Add(baby);
            return baby;
        }
        // Instance method to "multiply".
        public Person ProcreateWith(Person partner)
        {
            return Procreate(this, partner);
        }
        #endregion

        #region Delegates
     
        public int LengthOfText(string text) {
        
        return text.Length;
        }



        #endregion

        public void Hire(Person manager, Person employee)
        {
            ArgumentNullException.ThrowIfNull(manager);
            ArgumentNullException.ThrowIfNull(employee);
           
}           


    }
}
