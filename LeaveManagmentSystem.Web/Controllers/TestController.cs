using LeaveManagmentSystem.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagmentSystem.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var data = new TestViewModel
            {
                Name = "Studento of MVS Mastary",
                DateOfBirth = new DateTime(1990, 12, 13)
            };
            return View(data);
        }
    }
}
