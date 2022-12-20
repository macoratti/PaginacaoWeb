using Microsoft.AspNetCore.Mvc;
using PaginacaoWeb.Models;
using PaginacaoWeb.Paginacao;

namespace PaginacaoWeb.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _ctx;

    public HomeController(AppDbContext ctx)
    {
        _ctx = ctx ?? throw new ArgumentNullException(nameof(ctx));
    }

    public IActionResult Index(int page = 1)
    {
        var dataProducts = _ctx.Products.GetPaged(page, 8);
        return View(dataProducts);
    }

    public IActionResult Privacy()
    {
        return View();
    }
}