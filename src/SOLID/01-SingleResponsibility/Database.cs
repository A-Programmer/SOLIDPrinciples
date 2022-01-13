using System;
using System.Collections.Generic;
using SOLID.Models;

namespace SOLID.Data
{
    public class Database
    {
        public static List<Employee> Employees { get; set; } = new List<Employee>();
    }
}
