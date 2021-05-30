using System;
using System.Collections.Generic;


namespace Classes
{
  class Program
  {
    static void Main(string[] args)
    {
      // Create an instance of a company. Name it whatever you like.
      DateTime founded = new DateTime(2021, 05, 28);
      Company HowardHacksaws = new Company("HowardHacksaws", founded);

      // Create three employees
      Employee Person1 = new Employee()
      {
        FirstName = "Traye",
        LastName = "Johnson",
        Title = "Coder",
        StartDate = new DateTime(2020, 03, 03)
      };

      Employee Person2 = new Employee()
      {
        FirstName = "Billy",
        LastName = "Bob",
        Title = "Janitor",
        StartDate = new DateTime(2020, 03, 03)
      };

      Employee Person3 = new Employee()
      {
        FirstName = "Janice",
        LastName = "Smith",
        Title = "Administrator",
        StartDate = new DateTime(2020, 03, 03)
      };
      // Assign the employees to the company
      List<Employee> AssignEmployees = new List<Employee>()
      {
        Person1,
        Person2,
        Person3
      };

      HowardHacksaws.Employees = AssignEmployees;

      void ListEmployees()
      {
        foreach (Employee person in AssignEmployees)
        {
          Console.WriteLine($"{person.FirstName} {person.LastName} does work for HowardHacksaws as {person.Title} since {person.StartDate}");
        }
      }
      ListEmployees();

      /*
          Iterate the company's employee list and generate the
          simple report shown above
      */
    }
  }
}