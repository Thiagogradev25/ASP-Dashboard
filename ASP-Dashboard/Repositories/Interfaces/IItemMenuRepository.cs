using ASP_Dashboard.Models;

namespace ASP_Dashboard.Repositories.Interfaces;

public interface IItemMenuRepository
{
    IEnumerable<ItemMenuViewModel> ItemsMenu { get; }
}
