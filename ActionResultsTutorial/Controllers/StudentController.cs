using ActionResultsTutorial.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ActionResultsTutorial.Controllers
{
    public class StudentController : Controller
    {

        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public async Task<IActionResult> Index(string key="")
        {
            return View(await _studentService.GetAllByKeyAsync(key));
        }
    }
}
