using GymManager.ApplicationServices.Members;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
var provider = builder.Services.BuildServiceProvider();
var configuration = provider.GetService<IConfiguration>();

builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddTransient<IMembersAppService, MembersAppService>();

var app = builder.Build();
app.UseStaticFiles();
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
    endpoints.MapControllerRoute("MemberIn", "/Attendance/MemberIn", new { controller = "Attendance", action = "MemberIn" });
    endpoints.MapControllerRoute("MemberOut", "/Attendance/MemberOut", new { controller = "Attendance", action = "MemberOut" });
});

app.Run();
