using System;
using System.Collections.Generic;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee thingz = new Employee();
                thingz.Name = "Krissy";
                thingz.JobTitle = "Photographer";
                thingz.StartDate = DateTime.Now;
            
            Company taco = new Company("Target", DateTime.Now);
                taco.addEmployee(thingz);

                foreach(Employee e in taco.employeeList)
                {
                    Console.WriteLine(e.Name);
                }
        }
    }
    public class Company
    {
        /*
        Some readonly properties
        */
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a property for holding a list of current employees
        public List <Employee> employeeList = new List<Employee>();
        
        
        // Create a method that allows external code to add an employee

        public void addEmployee(Employee employee)
        {
            employeeList.Add(employee);

        }

        // Create a method that allows external code to remove an employee

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */
        public Company (string Thingz, DateTime Taco)
            {
                this.Name = Thingz;
                this.CreatedOn = Taco;
            }
        }

    public class Employee 
    {
        // 1. Create a class that contains information about employees of a company and define methods to get/set employee name, 
        // job title, and start date.
        public string Name {get; set;}
        public string JobTitle {get; set;}
        
        public DateTime StartDate {get; set;}

    }
}
