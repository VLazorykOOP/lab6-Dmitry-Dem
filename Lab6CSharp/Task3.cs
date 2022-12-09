using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6CSharp_Task3
{
    class DataBasePersons : IEnumerable
    {
        Person[] persons;
        public Person this[int index]
        {
            get
            {
                try
                {
                    return persons[index];
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        public DataBasePersons()
        {
            persons = new Person[0];
        }
        public void addPerson(Person person)
        {
            Person[] newPersonsList = new Person[persons.Length + 1];

            for (int i = 0; i < persons.Length; i++)
            {
                newPersonsList[i] = persons[i];
            }

            newPersonsList[newPersonsList.Length- 1] = person;

            persons = newPersonsList;
        }
        public void addPersons(IEnumerable<Person> inputPersons)
        {
            foreach (var person in inputPersons)
            {
                addPerson(person);
            }
        }
        public void removePersonByIndex(uint index)
        {
            try
            {
                Person[] newPersonsList = new Person[persons.Length - 1];

                uint j = 0;
                for (int i = 0; i < persons.Length; i++)
                {
                    if (i != index)
                    {
                        newPersonsList[j++] = persons[i];
                    }
                }

                Console.WriteLine($"\nObject: ({persons[index].Name}),({persons[index].Age}),({persons[index].DateOfBirth.ToShortDateString()}) - deleted!\n");
                persons = newPersonsList;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index Out Of Range Exception!");
            }
        }
        public void showPersonsList()
        {
            for (int i = 0; i < persons.Length; i++)
            {
                persons[i].showInformation();
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
        public PeopleEnum GetEnumerator()
        {
            return new PeopleEnum(persons);
        }
        public static void showPersonsWhoseAgeFallsIntoGivenRange(in IEnumerable<Person> persons, DateTime startDate, DateTime endDate)
        {
            Console.WriteLine($"\nPersons whose age falls into a given range ({startDate.ToShortDateString()}-{endDate.ToShortDateString()}): ");
            foreach (var person in persons)
            {
                if (person.DateOfBirth >= startDate && person.DateOfBirth <= endDate)
                {
                    person.showInformation();
                }
            }
        }
    }
    class PeopleEnum : IEnumerator
    {
        public Person[] _people;
        int position = -1;
        public PeopleEnum(Person[] list)
        {
            _people = list;
        }
        public bool MoveNext()
        {
            position++;
            return (position < _people.Length);
        }
        public void Reset()
        {
            position = -1;
        }
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
        public Person Current
        {
            get
            {
                try
                {
                    return _people[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
    abstract class Person
    {
        virtual public string Name { get; set; }
        virtual public string SureName { get; set; }
        virtual public DateTime DateOfBirth { get; set; }
        virtual public uint Age
        {
            get 
            { 
                return (uint)(DateTime.UtcNow.Year - DateOfBirth.Year);
            }
        }
        virtual public void showInformation()
        {
            Console.Write($"Name: {Name}, Sure Name: {SureName}, Age: {Age}, Date Of Birth: {DateOfBirth.ToShortDateString()}");
        }
        public Person()
        {
            Name = string.Empty;
            SureName= string.Empty;
            DateOfBirth = DateTime.MinValue;
        }
        public Person(string name, string sureName, DateTime dateOfBirth)
        {
            Name = name;
            SureName = sureName;
            DateOfBirth = dateOfBirth;
        }
    }
    class Entrant : Person
    {
        public string Faculty { get; set; }
        public Entrant() : base()
        {
            
        }
        public Entrant(string name, string sureName, DateTime dateOfBirth, string faculty) : base(name, sureName, dateOfBirth)
        {
            Faculty = faculty;
        }
        public override void showInformation()
        {
            base.showInformation();
            Console.WriteLine($", Faculty: {Faculty}");
        }
    }
    class Student : Person
    {
        public string Faculty { get; set; }
        public uint Course { get; set; }
        public Student() : base()
        {

        }
        public Student(string name, string sureName, DateTime dateOfBirth, string faculty, uint course) : base(name, sureName, dateOfBirth)
        {
            Faculty = faculty;
            Course = course;
        }
        public override void showInformation()
        {
            base.showInformation();
            Console.WriteLine($", Faculty: {Faculty}, Course: {Course}");
        }
    }
    class Teacher : Person
    {
        public string Faculty { get; set; }
        public string Post { get; set; }
        public string Experience { get; set; }
        public Teacher() : base()
        {

        }
        public Teacher(string name, string sureName, DateTime dateOfBirth, string faculty, string post, string experience) : base(name, sureName, dateOfBirth)
        {
            Faculty = faculty;
            Post = post;
            Experience = experience;
        }
        public override void showInformation()
        {
            base.showInformation();
            Console.WriteLine($", Faculty: {Faculty}, Post: {Post}, Experience: {Experience}");
        }
    }
}
