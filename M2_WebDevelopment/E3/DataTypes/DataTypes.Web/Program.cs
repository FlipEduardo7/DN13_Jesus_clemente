using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
var provider = builder.Services.BuildServiceProvider();
var configuration = provider.GetService<IConfiguration>();

builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/index.html", async context =>
    {
        await context.Response.WriteAsync("2");
    });
    endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
});


app.Run();
