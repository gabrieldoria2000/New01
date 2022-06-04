using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using New01.Data;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddDbContext<New01Context>(options =>
 //   options.UseSqlServer(builder.Configuration.GetConnectionString("New01Context") ?? throw new InvalidOperationException("Connection string 'New01Context' not found.")));

string connectionString = builder.Configuration.GetConnectionString("New01Context");


// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<New01Context>(options =>
            options.UseMySql(
                connectionString, ServerVersion.AutoDetect(connectionString)));

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
