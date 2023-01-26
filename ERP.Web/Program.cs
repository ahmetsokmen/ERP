using ERP.Core.Entities;
using ERP.Core.Entities.asdasd;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();

ConfigurationManager configuration = builder.Configuration;


builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddIdentity<Employee, AppRole>(options =>
{
	options.User.RequireUniqueEmail = false;
	options.Password.RequiredLength = 4;
	options.Password.RequireNonAlphanumeric = false;
	options.Password.RequireLowercase = false;
	options.Password.RequireUppercase = false;
	options.Password.RequireDigit = false;
})
	.AddEntityFrameworkStores<AppDbContext>()
	.AddDefaultTokenProviders();


builder.Services.AddControllersWithViews();





var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");

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
