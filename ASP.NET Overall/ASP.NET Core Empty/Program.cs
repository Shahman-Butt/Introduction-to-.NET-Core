using ASP.NET_Core_Empty.Middlewares;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


//builder.Services.AddSession(options =>
//{
//    options.IdleTimeout = TimeSpan.FromSeconds(5);
//    options.Cookie.HttpOnly = true;
//    options.Cookie.IsEssential = true;
//});

app.UseFirstMiddleware();

app.UseDefaultFiles();

app.UseStaticFiles();

//app.UseSession();
//app.UseSession();

//app.MapGet("/", () => "Hello World!");

//app.MapGet("/hello")

app.Run();

