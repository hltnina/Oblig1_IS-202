using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

public class BrukerController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}