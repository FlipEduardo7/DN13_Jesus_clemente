var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseStaticFiles();

app.MapGet("/", () => "Hello World!");
app.MapGet("/File1.html", () => (DateTime.Now.ToString()));

app.Run();
