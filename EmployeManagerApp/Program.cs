using System;

//Source code for: https://www.codemartini.com/get-employees-under-manager/

namespace EmployeManagerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create reporting structure
            var head = new Manager("Bob"); // top manager
            head.Add(new Employee("Paul"));
            head.Add(new Employee("Mike"));

            var manager1 = new Manager("Amit");
            manager1.Add(new Employee("Raj"));
            manager1.Add(new Employee("Dev"));
            head.Add(manager1);

            var manager2 = new Manager("Don");
            manager2.Add(new Employee("Lucy"));
            manager1.Add(manager2);

            // Add and remove a Temp employee
            var temp = new Employee("Bill");
            head.Add(temp);
            head.Remove(temp);

            // Recursively display tree
            head.Display("");
            head.GetEmployeeCount();
            Console.ReadKey();
        }
    }
}
