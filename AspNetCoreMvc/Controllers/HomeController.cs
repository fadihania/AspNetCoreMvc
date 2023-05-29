using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMvc.Controllers;

public class HomeController : Controller
{
    // "/"
    // "/Home"
    // "/Home/Index"
    public IActionResult Index()
    {
        //return Json("Home page");
        //return Content("Home page");
        //return Content("<h1>Home page</h1>", "text/html");
        //return View("First.cshtml");
        return View("First");
    }

    // "/Home/Bio"
    public IActionResult Bio()
    {
        //return "Web Developer";
        return View();
    }
}
