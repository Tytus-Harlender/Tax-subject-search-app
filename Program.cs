using _19_07_2023_task1.Data;
using _19_07_2023_task1.Data.Repositories;
using _19_07_2023_task1.Data.Repositories.Interfaces;
using _19_07_2023_task1.Services;
using _19_07_2023_task1.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<TaxSubjectsDbContext>();

builder.Services.AddScoped<ITaxSubjectsApiCaller,TaxSubjectApiCaller>();
builder.Services.AddScoped<ITaxSubjectDbService, TaxSubjectDbService>();
builder.Services.AddScoped<ITaxDataSearchRepository, TaxDataSearchRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
