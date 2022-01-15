using System;
using System.IO;
using SOLID.Data;
using SOLID.Models;

namespace SOLID.Services
{
    public class EmployeeServices
    {
        public void Add(Employee employee)
        {
            Database.Employees.Add(employee);

            Logger.Log("New employee has been added to the database.");
        }
    }
}
