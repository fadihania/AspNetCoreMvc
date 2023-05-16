var builder = WebApplication.CreateBuilder(args);

// Services
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Middlewares
// Default routing: /controller/action/id?
// Default route: /Home/Index
app.MapDefaultControllerRoute();

app.Run();
