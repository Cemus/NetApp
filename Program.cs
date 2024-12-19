var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.MapControllerRoute(
    name: "home",
    pattern: "/",
    defaults: new { controller = "Home", action = "Index" });


app.MapControllerRoute(
    name: "products",
    pattern: "/products",
    defaults: new { controller = "Products", action = "Index" });


app.MapControllerRoute(
    name: "productDetail",
    pattern: "/products/detail/{id}",
    defaults: new { controller = "Products", action = "Detail" });

app.Run();
