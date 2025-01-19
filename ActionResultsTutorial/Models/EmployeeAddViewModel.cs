using ActionResultsTutorial.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ActionResultsTutorial.Models
{
    public class EmployeeAddViewModel
    {
        public Employee Employee { get; set; }
        public List<SelectListItem> Cities { get; set; }
    }
}