using Microsoft.EntityFrameworkCore;
using WindsorPricesMonitoringWeb.Shared.Abstractions;
using WindsorPricesMonitoringWeb.Shared.Implementation;
using WindsorPricesMonitoringWeb.Shared.Model.Database;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

// Add services to the container.

services.AddControllersWithViews();
services.AddRazorPages();

services.AddScoped<IUnitProcessor, UnitProcessor>();
services.AddScoped<IApartmentProcessor, ApartmentProcessor>();
services.AddScoped<IUnitRepository, UnitRepository>();
services.AddScoped<IApartmentRepository, ApartmentRepository>();

services.AddDbContextFactory<PricesContext>(opt => 
	opt.UseSqlServer(builder.Configuration.GetValue<string>("ConnectionString")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseWebAssemblyDebugging();
}
else
{
	app.UseExceptionHandler("/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
