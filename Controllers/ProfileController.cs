using Microsoft.AspNetCore.Mvc;

namespace WebNews.Controllers;

[Route("[controller]")]
public class ProfileController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public ProfileController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet, Route("")]
    public IActionResult Index()
    {
        return View();
    }
}
