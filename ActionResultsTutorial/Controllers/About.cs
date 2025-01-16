using Microsoft.AspNetCore.Mvc;

namespace ActionResultsTutorial.Controllers
{
    public class About : Controller
    {
        public string  Index()
        {
            return "Hello wrom About Index";
        }
    }
}
