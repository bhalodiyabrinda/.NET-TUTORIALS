using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial3
{
    public class Person
    {
        // Task 2: Private data members
        private string name;
        private int age;

        // Task 3: Public methods to interact with private data members

        // Method to set the name
        public void SetName(string personName)
        {
            name = personName; // Assigns the value to private data member 'name'
        }

        // Method to set the age
        public void SetAge(int personAge)
        {
            age = personAge; // Assigns the value to private data member 'age'
        }

        // Method to get the name
        public string GetName()
        {
            return name; // Returns the value of 'name'
        }

        // Method to get the age
        public int GetAge()
        {
            return age; // Returns the value of 'age'
        }

        // Method to display details of the person
        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }
    }

    // Task 4: Demo class with main method
    public class Demo
    {
        public static void Main(string[] args)
        {
            // Task 5: Create objects of the 'Person' class
            Person person1 = new Person();
            Person person2 = new Person();

            // Set data for person1
            person1.SetName("Alice");
            person1.SetAge(25);

            // Set data for person2
            person2.SetName("Bob");
            person2.SetAge(30);

            // Task 6: Call methods using objects and display their details
            Console.WriteLine("Details of person1:");
            person1.DisplayDetails(); // Displays: Name: Alice, Age: 25

            Console.WriteLine("Details of person2:");
            person2.DisplayDetails(); // Displays: Name: Bob, Age: 30
        }
    }
}
