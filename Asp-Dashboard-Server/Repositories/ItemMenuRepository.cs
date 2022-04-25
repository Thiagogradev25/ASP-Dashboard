using ASP_Dashboard_Server.Context;
using ASP_Dashboard_Server.Models;
using ASP_Dashboard_Server.Repositories.Interfaces;

namespace ASP_Dashboard_Server.Repositories;

public class ItemMenuRepository : IItemMenuRepository

{
    private readonly AppDbContext _context;

    public ItemMenuRepository(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<ItemMenu> ItemsMenu => _context.ItemsMenu;

 
}
