using System;
using System.Collections.Generic;

namespace Classes
{
  public class Employee
  {
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Title { get; set; }

    // Calculated property that has no setter. It is readonly.
    public DateTime StartDate { get; set; }
  }
}