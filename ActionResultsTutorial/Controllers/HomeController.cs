using ActionResultsTutorial.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ActionResultsTutorial.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello From Index action";
        }

        public IActionResult Index2()
        {
            return View();
        }

        public ViewResult Employee1()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee()
                {
                    Id = 1,
                    Firstname = "Tural",
                    Lastname = "Huseynli",
                    CityId = 1,
                },
                new Employee()
                {
                    Id=2,
                    Firstname="Mehemmed",
                    Lastname = "Humbetli",
                    CityId = 2,
                },
                 new Employee()
                {
                    Id=3,
                    Firstname="Veli",
                    Lastname = "Kerimli",
                    CityId = 3,
                }
            };

            return View(employees);

        }

        public ViewResult Employee2()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee()
                {
                    Id = 1,
                    Firstname = "Tural",
                    Lastname = "Huseynli",
                    CityId = 1,
                },
                new Employee()
                {
                    Id=2,
                    Firstname="Mehemmed",
                    Lastname = "Humbetli",
                    CityId = 2,
                },
                 new Employee()
                {
                    Id=3,
                    Firstname="Veli",
                    Lastname = "Kerimli",
                    CityId = 3,
                }
            };

            return View(employees);

        }


    }
}