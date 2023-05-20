using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMvc.Controllers;

[Route("About")]
[Route("AboutUs")]
public class AboutController
{
    [Route("")]
    [Route("Contact")]
    public string Contact()
    {
        return "This a contact page";
    }
}
