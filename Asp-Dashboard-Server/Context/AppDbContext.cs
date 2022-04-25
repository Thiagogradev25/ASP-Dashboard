using ASP_Dashboard_Server.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP_Dashboard_Server.Context;

public class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            @"Data Source=138.97.105.135;Initial Catalog=asplan;User ID=asplan2;Password=setasp@3305;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=true");
    }


    public DbSet<ItemMenu> ItemsMenu { get; set; }


}

