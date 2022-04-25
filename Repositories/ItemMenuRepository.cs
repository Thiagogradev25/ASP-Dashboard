using ASP_Dashboard.Context;
using ASP_Dashboard.Models;
using ASP_Dashboard.Repositories.Interfaces;

namespace ASP_Dashboard.Repositories
{
    public class ItemMenuRepository : IItemMenuRepository

    {
        private readonly AppDbContext _context;

        public ItemMenuRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<ItemMenu> ItemsMenu => _context.ItemsMenu;
    }
}
