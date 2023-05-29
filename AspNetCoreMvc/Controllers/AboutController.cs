using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMvc.Controllers;

[Route("About")]
[Route("AboutUs")]
public class AboutController : Controller
{
    [Route("")]
    [Route("Contact")]
    public IActionResult Contact()
    {
        return View();
    }
}
