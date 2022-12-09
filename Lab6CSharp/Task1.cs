using Lab6CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6CSharp_Task1
{
    abstract class Organization : IShowe, IComparable
    {
        public virtual string Name { get; set; }
        public virtual string Address { get; set; }
        public virtual string Classification { get; set; }
        public Organization()
        {
            Name = "empty";
            Address = "empty";
            Classification = "empty";

            Console.WriteLine($"Organization Constructor: {this.GetType().Name}");
        }
        public Organization(string name)
        {
            Name = name;

            Console.WriteLine($"Organization Constructor (name): {this.GetType().Name}");
        }
        public Organization(string name, string address) : this(name)
        {
            Address = address;

            Console.WriteLine($"Organization Constructor (name, address): {this.GetType().Name}");
        }
        public Organization(string name, string address, string classification) : this(name, address)
        {
            Classification = classification;

            Console.WriteLine($"Organization Constructor (name, address, classification): {this.GetType().Name}");
        }
        ~Organization()
        {
            Console.WriteLine($"Organization Destructor: {this.GetType().Name}");
        }
        public virtual void showInformation() => Console.Write($"\n{this.GetType().Name}:  Name: {Name}  Address: {Address}  Classification: {Classification}  ");
        public int CompareTo(object? obj)
        {
            Organization? person = obj as Organization;

            if (obj != null)
            {
                return Name[0] == person.Name[0] ? 0 : (Name[0] > person.Name[0] ? 1 : -1);
            }
            else
            {
                throw new Exception();
            }
        }
    }
    class InsuranceCompany : Organization
    {
        public string TypeProperty { get; set; }
        public InsuranceCompany()
        {
            TypeProperty = "empty";

            Console.WriteLine($"Constructor: {this.GetType().Name}");
        }
        public InsuranceCompany(string name) : base(name)
        {
            Console.WriteLine($"Constructor: {this.GetType().Name}");
        }
        public InsuranceCompany(string name, string address) : base(name, address)
        {
            Console.WriteLine($"Constructor: {this.GetType().Name}");
        }
        public InsuranceCompany(string name, string address, string classification, string typeProperty) : base(name, address, classification)
        {
            TypeProperty = typeProperty;

            Console.WriteLine($"Constructor: {this.GetType().Name}");
        }
        ~InsuranceCompany()
        {
            Console.WriteLine($"Destructor: {this.GetType().Name}");
        }
        public new void showInformation()
        {
            base.showInformation();
            Console.Write($"Type of Property: {TypeProperty}");
        }
    }
    class Plant : Organization
    {
        public string Owner { get; set; }
        public Plant()
        {
            Owner = "empty";

            Console.WriteLine($"Constructor: {this.GetType().Name}");
        }
        public Plant(string name) : base(name)
        {
            Console.WriteLine($"Constructor: {this.GetType().Name}");
        }
        public Plant(string name, string address) : base(name, address)
        {
            Console.WriteLine($"Constructor: {this.GetType().Name}");
        }
        public Plant(string name, string address, string classification, string owner) : base(name, address, classification)
        {
            Owner = owner;

            Console.WriteLine($"Constructor: {this.GetType().Name}");
        }
        ~Plant()
        {
            Console.WriteLine($"Destructor: {this.GetType().Name}");
        }
        public new void showInformation()
        {
            base.showInformation();
            Console.Write($"Owner: {Owner}");
        }
    }
    class OilGasCompany : Organization
    {
        public string NumberPumpingStations { get; set; }
        public string NumberGasProcessingPlants { get; set; }
        public string Owner { get; set; }
        public OilGasCompany()
        {
            Owner = "empty";
            NumberPumpingStations = "empty";
            NumberGasProcessingPlants = "empty";

            Console.WriteLine($"Constructor: {this.GetType().Name}");
        }
        public OilGasCompany(string name) : base(name)
        {
            Console.WriteLine($"Constructor: {this.GetType().Name}");
        }
        public OilGasCompany(string name, string address) : base(name, address)
        {
            Console.WriteLine($"Constructor: {this.GetType().Name}");
        }
        public OilGasCompany(string name, string address, string classification, string owner, string numberPumpingStations, string numberGasProcessingPlants) : base(name, address, classification)
        {
            Owner = owner;
            NumberPumpingStations = numberPumpingStations;
            NumberGasProcessingPlants = numberGasProcessingPlants;

            Console.WriteLine($"Constructor: {this.GetType().Name}");
        }
        ~OilGasCompany()
        {
            Console.WriteLine($"Destructor: {this.GetType().Name}");
        }
        public new void showInformation()
        {
            base.showInformation();
            Console.Write($"Owner: {Owner} The number pumping stations: {NumberPumpingStations} The number gas processing plants: {NumberGasProcessingPlants}\n\n\n");
        }
    }
}
