var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
var app = builder.Build();
app.UseStaticFiles();
app.UseRouting();



//Controller Action Id
app.MapControllerRoute(
    name:"defalut",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);
app.Run();
