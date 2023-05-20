var builder = WebApplication.CreateBuilder(args);

// Services
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Middlewares
app.UseHttpsRedirection();
// Default routing: /controller/action/id?
// Default route: /Home/Index
// Attribute routing
app.MapDefaultControllerRoute();

app.Run();
