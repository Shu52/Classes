using System;
using System.Collections.Generic;

// Instructions
// Create a custom type for Employee. An employee has the following properties.
// First name (string)
// Last name (string)
// Title (string)
// Start date (DateTime)
public class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Title { get; set; }

    public DateTime StartDate { get; set; }
}
// Create a custom type for Company. A company has the following properties.
// Date founded (DateTime)
// Company name (string)
// Employees (List<Employee>)
public class Company
{

    // Some readonly properties (let's talk about gets, baby)
    public string Name { get; set; }
    public DateTime CreatedOn { get;set;}

    public List<Employee> CurrentEmployees = new List<Employee>();

    // Create a public property for holding a list of current employees
    public Company(string CompanyName, DateTime CompanyFounded)
    {
        Name = CompanyName;
        CreatedOn = CompanyFounded;
    }
    /*
        Create a constructor method that accepts two arguments:
            1. The name of the company
            2. The date it was created

        The constructor will set the value of the public properties
    */
    public void ListEmployees(){
        foreach (var Employee in CurrentEmployees)
        {
            //name works for company name as title since employee start date
            Console.WriteLine($"{Employee.FirstName} {Employee.LastName} works for {this.Name} as {Employee.Title} since {Employee.StartDate.ToShortDateString()}");
        }
    }
// The Company class should also have a ListEmployees() method which outputs the name of each employee to the console.
}


namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company NSS = new Company("NSS",new DateTime(2010,1,1));
            
            // Create three employees
            Employee One = new Employee(){
                FirstName = "Sathvik",
                LastName = "Reddy",
                Title = "Junior Developer",
                StartDate = new DateTime(2018,5,21)
            };

            Employee Two = new Employee(){
                FirstName = "John",
                LastName = "Wark",
                Title = "Founder",
                StartDate = new DateTime(2010,1,1)
            };

            Employee Three = new Employee(){
                FirstName = "Shu",
                LastName = "Sajid",
                Title = "Village Idiot",
                StartDate = new DateTime(2018,5,21)
            };
            // Assign the employees to the company
            NSS.CurrentEmployees.Add(One);
            NSS.CurrentEmployees.Add(Two);
            NSS.CurrentEmployees.Add(Three);
            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            NSS.ListEmployees();
        }
    }
}