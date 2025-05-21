using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FirstMvc.Models;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace FirstMvc.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    public static List<Pet> Pets = new List<Pet>();

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
    [HttpPost("pet/create")]
    public IActionResult Create(Pet newPet)
    {
        if (ModelState.IsValid)
        {

        Console.WriteLine(newPet.Name);
            // this means we passed our validation
            // then would you redirect to anyPage
            Pets.Add(newPet);
            return RedirectToAction("Success");
        }
        else
        {
            return View("Index");
        }
    }

    [HttpGet("Success")]
    public IActionResult Success()
    {
        return View("Success",Pets);

    }
    
     
    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
