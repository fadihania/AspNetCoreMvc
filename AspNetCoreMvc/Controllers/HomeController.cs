namespace AspNetCoreMvc.Controllers;

public class HomeController
{
    // "/"
    // "/Home"
    // "/Home/Index"
    public string Index()
    {
        return "Home page";
    }

    // "/Home/Bio"
    public string Bio()
    {
        return "Web Developer";
    }
}
