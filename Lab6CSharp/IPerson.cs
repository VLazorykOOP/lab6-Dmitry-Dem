using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab6CSharp;

namespace Lab6CSharp_Task2
{
    interface IPerson : IShowe, IComparable
    {
        string Name { get; set; }
        string SureName { get; set; }
        DateTime DateOfBirth { get; set; }
        uint Age
        {
            get
            {
                return (uint)(DateTime.UtcNow.Year - DateOfBirth.Year);
            }
        }
        void showInformation()
        {
            Console.Write($"Name: {Name}, Sure Name: {SureName}, Age: {Age}, Date Of Birth: {DateOfBirth.ToShortDateString()}");
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
