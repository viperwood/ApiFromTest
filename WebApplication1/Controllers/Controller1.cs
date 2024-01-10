using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

public class Controller1 : Controller
{
    // GET
    public IActionResult Index()
    {
        return Ok();
    }
}