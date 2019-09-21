using System;
using System.Collections.Generic;

namespace EmployeManagerApp
{
    /// <summary>
    /// The Manager class
    /// </summary>
    public class Manager : Employee, IManager
    {
        private List<IEmployee> _subordinates = new List<IEmployee>();

        public int Count { get { return _subordinates.Count + 1; } }

        // Constructor
        public Manager(string name) : base(name)
        {
        }

        public void Add(IEmployee component)
        {
            _subordinates.Add(component);
        }

        public void Remove(IEmployee component)
        {
            _subordinates.Remove(component);
        }

        public override void Display(string name)
        {
            Console.WriteLine($"{name} - {Name}");

            // Recursively display child nodes
            foreach (var component in _subordinates)
            {
                component.Display($"{name} - {Name}");
            }
        }

        public void Display2(int depth)
        {
            Console.WriteLine(new string('-', depth) + Name);

            // Recursively display child nodes
            foreach (var component in _subordinates)
            {
                // component.Display(depth + 2);
            }
        }

        public override int GetEmployeeCount()
        {
            int cnt = 1;
            foreach (var employee in _subordinates)
            {
                cnt += employee.GetEmployeeCount();
            }

            Console.WriteLine($"{Name} has {cnt - 1} employees");
            return cnt;
        }
    }
}
