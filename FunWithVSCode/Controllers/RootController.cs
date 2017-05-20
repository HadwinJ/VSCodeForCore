using Microsoft.AspNetCore.Mvc;

namespace FunWithVSCode.Controllers
{
    public class RootController: Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult Contact()
        {
          
          return View();
        }

        public IActionResult About()
        {
          
          return View();
        }
    }
}