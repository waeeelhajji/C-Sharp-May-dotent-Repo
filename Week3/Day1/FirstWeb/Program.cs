var builder = WebApplication.CreateBuilder(args);
//! Services brought in before you build
builder.Services.AddControllersWithViews();
var app = builder.Build();

// Bring in some features for our app
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// Tell our projext to run using the controller
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


// this is ALWAYS the line
app.Run();
