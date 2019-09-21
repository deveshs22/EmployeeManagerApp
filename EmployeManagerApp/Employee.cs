using System;

namespace EmployeManagerApp
{
    /// <summary>
    /// The Employee class
    /// </summary>
    public class Employee : IEmployee
    {
        public Employee(string name)
        {
            Name = name;
        }

        public virtual void Display(string name)
        {
            Console.WriteLine($"{name} - {Name}");
        }

        public string Name { get; set; }

        public virtual int GetEmployeeCount()
        {
            return 1; // Employee
        }
    }
}
