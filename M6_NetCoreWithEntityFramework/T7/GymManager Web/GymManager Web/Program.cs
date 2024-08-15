using GymManager.ApplicationServices.Members;
using GymManager.ApplicationServices.Memberships;
using GymManager.ApplicationServices.Navigation;
using GymManager.Core.Members;
using GymManager.DataAccess;
using GymManager.DataAccess.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Serilog;

var builder = WebApplication.CreateBuilder(args);
var provider = builder.Services.BuildServiceProvider();
var configuration = provider.GetService<IConfiguration>();

string connectionString = configuration.GetConnectionString("Default");

Log.Logger = new LoggerConfiguration()
    .ReadFrom.Configuration(builder.Configuration)
    .MinimumLevel.Debug()
    .Enrich.FromLogContext()
    .WriteTo.Console()
    .WriteTo.File(@"F:\GymManager Web\GymManager Web\Logs\log.txt", rollingInterval: RollingInterval.Infinite)
    .CreateLogger();

//Log.Logger = new LoggerConfiguration()
//    .ReadFrom.Configuration(builder.Configuration)
//    .CreateLogger();

builder.Host.UseSerilog();
builder.Services.AddControllers();

builder.Services.AddDbContext<GymManagerContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<GymManagerContext>().AddUserStore<UserStore<IdentityUser, IdentityRole, GymManagerContext>>();

builder.Services.ConfigureApplicationCookie(options =>
{
    options.Cookie.HttpOnly = true;
    options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
    options.LoginPath = "/Account/Login";
    options.SlidingExpiration = true;
});
//builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
//    .AddCookie(options =>
//    {
//        options.LoginPath = "/Account/Login";
//        options.AccessDeniedPath = "/";
//    });
builder.Services.AddAuthorization();

builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddTransient<IMembersAppService, MembersAppService>();
builder.Services.AddTransient<IMenuAppService, MenuAppService>();
builder.Services.AddTransient<IMembershipAppService, MembershipAppService>();
builder.Services.AddTransient< IRepository<int, Member>, MembersRepository >();

var app = builder.Build();
app.UseDeveloperExceptionPage();
app.UseStaticFiles();
app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();
app.UseAuthentication();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
    endpoints.MapControllerRoute("MemberIn", "/Attendance/MemberIn", new { controller = "Attendance", action = "MemberIn" });
    endpoints.MapControllerRoute("MemberOut", "/Attendance/MemberOut", new { controller = "Attendance", action = "MemberOut" });
});

app.Run();
