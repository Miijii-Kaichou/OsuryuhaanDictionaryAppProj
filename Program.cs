var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapDefaultControllerRoute();
app.UseRouting();
app.MapControllers();
app.UseStaticFiles();

app.MapFallbackToFile("index.html");

app.Run();