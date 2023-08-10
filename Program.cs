using TH.TS01.Models;
using TH.TS01.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ThDbContext>();

builder.Services.AddScoped<IUserServices, UserServices>();
builder.Services.AddScoped<ITimeSheetServices, TimeSheetServices>();

builder.Services.AddCors();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseCors(options =>
     options.WithOrigins("http://localhost:3000")
            .AllowAnyHeader()
            .AllowAnyMethod());


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;

app.Run();
