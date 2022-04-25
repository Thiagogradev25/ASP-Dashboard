using ASP_Dashboard.Repositories.Interfaces;

using Microsoft.AspNetCore.Mvc;

namespace ASP_Dashboard.Components;

public class CategoriaMenu : ViewComponent
{
    private readonly IItemMenuRepository _ItemMenuRepository;

    public CategoriaMenu(IItemMenuRepository itemMenuRepository)
    {
        _ItemMenuRepository = itemMenuRepository;
    }

    public IViewComponentResult Invoke()
    {
        var itemMenu = _ItemMenuRepository.ItemsMenu.OrderBy(c => c.DescMenu);
        return View(itemMenu);
    }
}
