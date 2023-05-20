# ASP.NET MVC
A sample .NET 7 MVC app that shows how to setup MVC apps and how to create Controllers, prepare Views and use Layouts

**Check commits for steps and how to apply different concepts**

- Model-View-Controller (MVC)

- All MVC apps must contain controllers
- Controllers prepare data and return a view if required
- ASP.NET MVC:
  + Add MVC services: `builder.Services.AddControllersWithViews();`
  + Add MVC middleware: `app.MapDefaultControllerRoute();`
     ■ This register default routing: `/[controller]/[action]/{id?}`
     ■ Register default route: `/Home/Index`
     ■ Register Attribute Routing
  + Create controller class and return value

- For more functionality:
  + Extend Controller class using Microsoft.AspNetCore.Mvc
  + Return IActionResult from action methods
  + Use `Content()`, `Json()` and `View()`
- Use Attribute Routing to provide custom routing
  + Disable default routing
  + Use `[Route()]` attribute on controller class and actions