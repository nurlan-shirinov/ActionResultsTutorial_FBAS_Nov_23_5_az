using ActionResultsTutorial.Entities;
using System.Collections.Generic;

namespace ActionResultsTutorial.Models
{
    public class EmployeeViewModel
    {
        public List<Employee> Employees { get; set; }
        public List<string> Cities { get; set; }
    }
}
