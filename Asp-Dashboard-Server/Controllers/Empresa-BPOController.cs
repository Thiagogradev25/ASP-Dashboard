
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASP_Dashboard_Server.Controllers;

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

    
    
}
