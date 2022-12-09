using Lab6CSharp_Task1;
using Lab6CSharp_Task2;
using Lab6CSharp_Task3;

Console.WriteLine("Lab6 C# Demenchuk Dmytro");

Task1.testTask1();
Task2.testTask2();
Task3.testTask3();

namespace Lab6CSharp_Task1
{
	class Task1
	{
		public static void testTask1()
		{
			Console.WriteLine("Task 1");

			Organization[] organizations =
			{
				new InsuranceCompany("A", "address 1", "class 1", "prop 1"),
				new Plant("D", "address 2", "class 2", "own 2"),
				new Plant("B", "address 4", "class 4", "own 4"),
				new OilGasCompany("C", "address 3", "class 3", "own 3", "4", "4")
			};

			Console.Write("\n\nNon sort array: ");
			foreach (var organization in organizations)
			{
				organization.showInformation();
			}

			Array.Sort(organizations);
			Console.Write("\n\nSorted array by Name: ");
			foreach (var organization in organizations)
			{
				organization.showInformation();
			}

			Console.WriteLine("\n\n");
		}
	}
}
namespace Lab6CSharp_Task2
{
	class Task2
	{
		private static void showPersonsWhoseAgeFallsIntoGivenRange(in IEnumerable<IPerson> persons, DateTime startDate, DateTime endDate)
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
		public static void testTask2()
		{
			Console.WriteLine("Task 2");

			IPerson[] persons =
			{
				new Entrant("Dmytro", "1", new DateTime(2003, 1, 1), "faculty 1"),
				new Student("Volodymyr", "2", new DateTime(2001, 5, 6), "faculty 2", 2),
				new Student("Andre", "3", new DateTime(2003, 2, 5), "faculty 1", 3),
				new Student("Bohdan", "4", new DateTime(2002, 4, 8), "faculty 3", 1),
				new Student("Alexandr", "5", new DateTime(2002, 7, 2), "faculty 2", 4),
				new Student("Dmytro", "6", new DateTime(2001, 3, 3), "faculty 1", 1),
				new Teacher("Anastasia", "3", new DateTime(2001, 1, 1), "faculty 3", "post 3", "exp 3")
			};

			Console.WriteLine("Non sort array: ");
			foreach (var person in persons)
			{
				person.showInformation();
			}

			Array.Sort(persons);
			Console.WriteLine("Sorted array (Date Of Birth): ");
			foreach (var person in persons)
			{
				person.showInformation();
			}

			showPersonsWhoseAgeFallsIntoGivenRange(persons, new DateTime(2002, 1, 1), new DateTime(2003, 1, 1));
			Console.WriteLine("\n\n");
		}
	}
}
namespace Lab6CSharp_Task3
{
	class Task3
	{
		public static void testTask3()
		{
			Console.WriteLine("Task 3");
			DataBasePersons dataBasePersons = new DataBasePersons();

			List<Person> persons = new List<Person>
			{
				new Entrant("Dmytro", "1", new DateTime(2003, 1, 1), "faculty 1"),
				new Student("Volodymyr", "2", new DateTime(2001, 5, 6), "faculty 2", 2),
				new Student("Andre", "3", new DateTime(2003, 2, 5), "faculty 1", 3),
				new Student("Bohdan", "4", new DateTime(2002, 4, 8), "faculty 3", 1),
				new Student("Alexandr", "5", new DateTime(2002, 7, 2), "faculty 2", 4),
				new Student("Dmytro", "6", new DateTime(2001, 3, 3), "faculty 1", 1),
				new Teacher("Anastasia", "3", new DateTime(2001, 1, 1), "faculty 3", "post 3", "exp 3")
			};

			dataBasePersons.addPersons(persons);
			dataBasePersons.showPersonsList();

			dataBasePersons.removePersonByIndex(2);

			foreach (var item in dataBasePersons)
			{
				item.showInformation();
			}

			DataBasePersons.showPersonsWhoseAgeFallsIntoGivenRange(persons, new DateTime(2002, 1, 1), new DateTime(2003, 1, 1));

			Console.WriteLine("\n\n");
		}
	}
}