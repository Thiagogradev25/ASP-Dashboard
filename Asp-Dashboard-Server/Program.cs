using ASP_Dashboard.Context;
using ASP_Dashboard.Repositories;
using ASP_Dashboard.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);
//builder.Configuration.GetConnectionString("DefaultConnection");

// Add services to the container.

builder.Services.AddDbContextFactory<AppDbContext>(options =>
   options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddTransient<IItemMenuRepository, ItemMenuRepository>();

builder.Services.AddRazorPages();
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

app.UseEndpoints(endpoints =>
{

    endpoints.MapControllerRoute(
     name: "default",
     pattern: "{controller=ItemMenu}/{action=List}/{id?}");

    //endpoints.MapControllerRoute(
    //name: "menu",
    //pattern: "{controller=Home}/{action=Index}/{id?}");


});


app.Run();
