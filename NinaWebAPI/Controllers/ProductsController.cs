using Microsoft.AspNetCore.Mvc;

namespace NinaWebAPI.Controllers;

public class ProductsController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}