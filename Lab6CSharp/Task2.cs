using Lab6CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab6CSharp_Task2
{
    class Entrant : IPerson
    {
        public string Name { get; set; }
        public string SureName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public uint Age
        {
            get
            {
                return (uint)(DateTime.UtcNow.Year - DateOfBirth.Year);
            }
        }
        public string Faculty { get; set; }
        public Entrant()
        {
            Name = string.Empty;
            SureName = string.Empty;
            DateOfBirth = DateTime.MinValue;
        }
        public Entrant(string name, string sureName, DateTime dateOfBirth, string faculty)
        {
            Name = name;
            SureName = sureName;
            DateOfBirth = dateOfBirth;
            Faculty = faculty;
        }
        public void showInformation()
        {
            Console.WriteLine($"Name: {Name}, Sure Name: {SureName}, Age: {Age}, Date Of Birth: {DateOfBirth.ToShortDateString()}, Faculty: {Faculty}");
        }
        public int CompareTo(object? obj)
        {
            IPerson? person = obj as IPerson;

            if (obj != null)
            {
                return DateOfBirth == person.DateOfBirth ? 0 : (DateOfBirth < person.DateOfBirth ? 1 : -1);
            }
            else
            {
                throw new Exception();
            }
        }
    }
    class Student : IPerson
    {
        public string Name { get; set; }
        public string SureName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public uint Age
        {
            get
            {
                return (uint)(DateTime.UtcNow.Year - DateOfBirth.Year);
            }
        }
        public string Faculty { get; set; }
        public uint Course { get; set; }
        public Student()
        {
            Name = string.Empty;
            SureName = string.Empty;
            DateOfBirth = DateTime.MinValue;
        }
        public Student(string name, string sureName, DateTime dateOfBirth, string faculty, uint course)
        {
            Name = name;
            SureName = sureName;
            DateOfBirth = dateOfBirth;
            Faculty = faculty;
            Course = course;
        }
        public void showInformation()
        {
            Console.WriteLine($"Name: {Name}, Sure Name: {SureName}, Age: {Age}, Date Of Birth: {DateOfBirth.ToShortDateString()}, Faculty: {Faculty}, Course: {Course}");
        }
        public int CompareTo(object? obj)
        {
            IPerson? person = obj as IPerson;

            if (obj != null)
            {
                return DateOfBirth == person.DateOfBirth ? 0 : (DateOfBirth < person.DateOfBirth ? 1 : -1);
            }
            else
            {
                throw new Exception();
            }
        }
    }
    class Teacher : IPerson
    {
        public string Name { get; set; }
        public string SureName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public uint Age
        {
            get
            {
                return (uint)(DateTime.UtcNow.Year - DateOfBirth.Year);
            }
        }
        public string Faculty { get; set; }
        public string Post { get; set; }
        public string Experience { get; set; }
        public Teacher() 
        {
            Name = string.Empty;
            SureName = string.Empty;
            DateOfBirth = DateTime.MinValue;
        }
        public Teacher(string name, string sureName, DateTime dateOfBirth, string faculty, string post, string experience)
        {
            Name = name;
            SureName = sureName;
            DateOfBirth = dateOfBirth;
            Faculty = faculty;
            Post = post;
            Experience = experience;
        }
        public void showInformation()
        {
            Console.WriteLine($"Name: {Name}, Sure Name: {SureName}, Age: {Age}, Date Of Birth: {DateOfBirth.ToShortDateString()}, Faculty: {Faculty}, Post: {Post}, Experience: {Experience}");
        }
        public int CompareTo(object? obj)
        {
            IPerson? person = obj as IPerson;

            if (obj != null)
            {
                return DateOfBirth == person.DateOfBirth ? 0 : (DateOfBirth < person.DateOfBirth ? 1 : -1);
            }
            else
            {
                throw new Exception();
            }
        }
    }
}