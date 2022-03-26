using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using cms.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
//builder.Services.AddScoped<CustomPageService>();
builder.Services.AddSingleton<UserService>();
builder.Services.AddSingleton<AuthService>();
/// Postgre SQL
var myConnString = builder.Configuration.GetConnectionString("myconn");
builder.Services.AddDbContext<AppDBContext>(item => item.UseNpgsql(myConnString));
/*
builder.Services.AddMvc(setupAction: options => options.EnableEndpointRouting = false)
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
*/
builder.Services.AddMvc(setupAction:options => options.EnableEndpointRouting = false);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

/// Added this MVC with DefaultRoute
app.UseMvcWithDefaultRoute();
///
app.UseStaticFiles();

app.UseRouting();
/// Added this COntroller stuff
/*
app.UseEndpoints(endpoints =>
{
    
});
*/
app.MapControllers();
//
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
