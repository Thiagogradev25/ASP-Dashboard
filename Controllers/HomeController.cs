using ASP_Dashboard.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASP_Dashboard.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult EmpresaBPO()
    {
        return View();
    }

    public IActionResult CopiaTabelas()
    {
        return View();
    }

    public IActionResult Empresas()
    {
        return View();
    }

    public IActionResult Usuarios()
    {
        return View();
    }

    public IActionResult Versao()
    {
        return View();
    }


    public IActionResult Volumetria()
    {
        return View();
    }

    public IActionResult Clientes()
    {
        return View();
    }

    public IActionResult Documentos()
    {
        return View();
    }

    public IActionResult Login()
    {
        return View();
    }


    public IActionResult Password()
    {
        return View();
    }


    public IActionResult Register()
    {
        return View();
    }









    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
