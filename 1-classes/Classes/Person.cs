using System;

namespace Classes
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime Birthdate { get; private set; }

        public Person(DateTime birthdate)
        {
            this.Birthdate = birthdate;
        }
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;

                return years;
            }
        }

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }


        public static Person Parse(string str)
        {
            var person = new Person(DateTime.Today.AddYears(-10));
            person.Name = str;

            return person;
        }

    }
}