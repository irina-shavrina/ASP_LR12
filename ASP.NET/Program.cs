using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);
string connection = builder.Configuration.GetConnectionString("dbcon");

builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connection));

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Main}/{action=Index}/");


app.Run();