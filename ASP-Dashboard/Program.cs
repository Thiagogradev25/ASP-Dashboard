using ASP_Dashboard_Server.Repositories;
using ASP_Dashboard_Server.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.



builder.Services.AddTransient<IItemMenuRepository, ItemMenuRepository>();

builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();




var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
   
    app.UseHsts();
}



app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();




app.Run();
