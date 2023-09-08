using Microsoft.AspNetCore.Mvc;

namespace Assignment_of_projects_and_tasks.Controllers
{
    public class AuthenticationController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}