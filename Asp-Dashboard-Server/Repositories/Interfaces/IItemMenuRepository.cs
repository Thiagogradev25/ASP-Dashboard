using ASP_Dashboard_Server.Models;

namespace ASP_Dashboard_Server.Repositories.Interfaces;

public interface IItemMenuRepository
{
    IEnumerable<ItemMenu> ItemsMenu { get; }
}
