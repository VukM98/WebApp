using FirstMvcApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FirstMvcApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Console.WriteLine("Hello from action method.");
            return View();
        }


        [HttpPost]
        public IActionResult Index(Person person)
        {

            if (ModelState.IsValid)
            {
                Attendance.AddAttendant(person);
                TempData["FirstName"] = person.FirstName + " " + person.LastName;
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
    }
}
