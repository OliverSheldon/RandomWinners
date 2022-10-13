using Domain.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//builder.Services.AddSingleton<PersonContext>(sp =>
//    {
//        using (var scope = sp.CreateScope())
//        {
//            var dbContext = scope.ServiceProvider.GetService<PersonContext>();

//            return dbContext;
//        }
//    });

builder.Services.AddDbContext<PersonContext>(options => options.UseSqlServer("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=Domain.Context.PersonContext;Integrated Security=True"));

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
