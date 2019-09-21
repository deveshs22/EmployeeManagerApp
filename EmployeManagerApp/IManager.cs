using System;

namespace EmployeManagerApp
{
    /// <summary>
    /// Iterface for Manager
    /// IManager extends IEmployee
    /// </summary>
    public interface IManager : IEmployee
    {
        void Add(IEmployee emp);
        void Remove(IEmployee emp);
    }
}
