using ASP_Dashboard.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ASP_Dashboard.Controllers
{
    public class ItemMenuController : Controller
    {


        private readonly IItemMenuRepository _ItemMenuRepository;

        public ItemMenuController(IItemMenuRepository itemMenuRepository)
        {
            _ItemMenuRepository = itemMenuRepository;
        }

        public IActionResult List()
        {
            var ItemsMenu = _ItemMenuRepository.ItemsMenu;
            return View(ItemsMenu);
        }

        public IActionResult Roteamento(string rota)
        {
            return View(rota);
        }

        public IActionResult Login()
        {
            return View();
        }


    }
}
