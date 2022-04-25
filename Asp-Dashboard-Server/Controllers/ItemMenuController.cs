using ASP_Dashboard_Server.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace ASP_Dashboard_Server.Controllers
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
            return View();
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
