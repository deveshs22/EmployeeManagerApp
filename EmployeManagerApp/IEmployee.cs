using System;

namespace EmployeManagerApp
{
    /// <summary>
    /// Interface for Employee
    /// </summary>
    public interface IEmployee
    {
        string Name { get; set; }

        //Display Name hierarchy a-> b->c
        void Display(string nameText);

        // Get Total Employees under each employee
        int GetEmployeeCount();
    }
}
