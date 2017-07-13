using System;
using System.Collections.Generic;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee newEmpl1 = new Employee ("Krissy", "CEO", DateTime.Now);
            Employee newEmpl2 = new Employee ("Marcus", "Social Media Director", DateTime.Now);
            Employee newEmpl3 = new Employee ("Kait", "Digital Marketing", DateTime.Now);
            
            Company taco = new Company("Target", DateTime.Now);
                taco.addEmployee(newEmpl1);
                taco.addEmployee(newEmpl2);
                taco.addEmployee(newEmpl3);

                taco.ListEmployees();
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
        public void removeEmployee(Employee employee)
        {
            employeeList.Remove(employee);
        }

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

            public void ListEmployees()
            {
                foreach(Employee each in this.employeeList)
                {
                   Console.WriteLine($"{each.EmplName} {each.JobTitle} {each.StartDate}"); 
                }
            }
        }

    public class Employee 
    {
        // 1. Create a class that contains information about employees of a company and define methods to get/set employee name, 
        // job title, and start date.
        public string EmplName {get; set;}
        public string JobTitle {get; set;}        
        public DateTime StartDate {get; set;}

        public Employee (string name, string title, DateTime date) 
        {
            EmplName = name;
            JobTitle = title;
            StartDate = date;
        }

    }
}
