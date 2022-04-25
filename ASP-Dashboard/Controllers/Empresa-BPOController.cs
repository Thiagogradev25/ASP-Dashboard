using ASP_Dashboard.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASP_Dashboard.Controllers;

public class Empresa_BPO : Controller
{

    private readonly ILogger<Empresa_BPO> _logger;

    public Empresa_BPO(ILogger<Empresa_BPO> logger)
    {
        _logger = logger;
    }
    public IActionResult Index()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
