using ActionResultsTutorial.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ActionResultsTutorial.Controllers
{
    public class EmployeeController : Controller
    {
        //Eger methodda [HTTPGET] tag i yazilmiyibsa default olaraq get dir

        [HttpGet]
        public IActionResult Add()
        {
            var vm = new EmployeeAddViewModel()
            {
                Employee = new Entities.Employee(),
                Cities = new List<SelectListItem>
                {
                    new SelectListItem {Text = "Baku" , Value="1"},
                    new SelectListItem {Text = "Gence" , Value="2"},
                    new SelectListItem {Text = "Sumqayit" , Value="3"},
                    new SelectListItem {Text = "Agdam" , Value="4"},
                }
            };
            return View(vm);
        }

        [HttpPost]
        public IActionResult Add(EmployeeAddViewModel viewModel)
        {
            var vm = new EmployeeAddViewModel()
            {
                Employee = new Entities.Employee(),
                Cities=new List<SelectListItem> { }
            };
            return View(vm);
        }
    }
}
