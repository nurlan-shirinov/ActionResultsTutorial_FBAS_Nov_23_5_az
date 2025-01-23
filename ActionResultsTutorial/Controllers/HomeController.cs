using ActionResultsTutorial.Entities;
using ActionResultsTutorial.Models;
using ActionResultsTutorial.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System.Collections.Generic;
using System.Linq;

namespace ActionResultsTutorial.Controllers
{
    public class HomeController : Controller
    {

        private readonly ICalculator _calculate1;
        private readonly ICalculator _calculate2;

        public HomeController(ICalculator calculate1, ICalculator calculate2)
        {
            _calculate1 = calculate1;
            _calculate2 = calculate2;
        }

        public string Index()
        {
            return $"Hello From Index action{_calculate1.Calculate()} - {_calculate2.Calculate()}";
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

            List<string> cities = new List<string>() { "Baku", "London", "New-York" };

            var vm = new EmployeeViewModel()
            {
                Cities = cities,
                Employees = employees
            };

            return View(vm);

        }

        public IActionResult Index4()
        {
            return Ok();
        }

        public IActionResult Index5()
        {
            return NotFound();
        }

        public IActionResult Index6()
        {
            return BadRequest();
        }

        public IActionResult Index7()
        {
            return Redirect("/about/index");
        }

        public IActionResult Index8()
        {
            return RedirectToAction("index");
        }

        public IActionResult Index9()
        {
            var routeValue = new RouteValueDictionary(
                new { action = "employee1", controller = "home" });

            return RedirectToRoute(routeValue);
        }

        public JsonResult GetJson()
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
                    Firstname="Mehemmedeli",
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
            return Json(employees);
        }

        //route param

        public JsonResult Index10(int id = -1)
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

            if (id == -1)
                return Json(employees);
            else
            {
                var data = employees.FirstOrDefault(e => e.Id == id);
                return Json(data);
            }
        }

        //Query Param

        public JsonResult Index11(string key, int id = -1)
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
                    Firstname="Mehemmedeli",
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
            if (id == -1)
            {
                var data = employees.Where(e => e.Firstname.Contains(key));
                return Json(data);
            }
            else
            {
                var data = employees.Where(e => e.Id == id || e.Firstname.Contains(key));
                return Json(data);
            }
        }

    }
}