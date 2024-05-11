using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using NET105_Lab1.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(op => op.UseSqlServer(
    builder.Configuration.GetConnectionString("Dbconection")));

// Add services to the container.
builder.Services.AddControllersWithViews();

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
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    var inf = new employee
    {

        employeeName = "Bhien",
        employeeAddress = "Da Nang",
        employeePhone="0773745555"
    };
    context.employees.Add(inf);
    context.SaveChanges();
    var context1 = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    var inf1 = new department
    {

        departmentName = "BA"
       
      
    };
    context.departments.Add(inf1);
    context.SaveChanges();


}

app.Run();
