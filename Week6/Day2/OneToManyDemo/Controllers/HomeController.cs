using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OneToManyDemo.Models;

namespace OneToManyDemo.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private MyContext _context;

    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;   
    }

    public IActionResult Index()
    {
        MyViewModel MyModel = new MyViewModel
        {
            AllMakers = _context.Makers.Include(a => a.AllVehicles).ToList()
        };
        return View(MyModel);
    }
    [HttpPost("makers/create")]
    public IActionResult CreateMaker(Maker newMaker)
    {
        if (ModelState.IsValid)
        {
            _context.Add(newMaker);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        else
        {
            MyViewModel MyModel = new MyViewModel
        {
            AllMakers = _context.Makers.Include(a => a.AllVehicles).ToList()
        };
            return View("Index",MyModel);
        }
    }

    public IActionResult Privacy()
    {
        MyViewModel MyModel = new MyViewModel
        {
            AllVehicles = _context.Vehicles.Include(b => b.Maker).ToList()

        };
        ViewBag.AllMakers = _context.Makers.ToList();
        return View(MyModel);
    }
    [HttpPost("Vehicles/create")]
    public IActionResult CreateVehicle(Vehicle newVehicle)
    {
        if (ModelState.IsValid)
        {
            _context.Add(newVehicle);
            _context.SaveChanges();
            return RedirectToAction("Privacy");
        }
        else
        {
            MyViewModel MyModel = new MyViewModel
        {
            AllVehicles = _context.Vehicles.Include(b => b.Maker).ToList()

        };
            return View("Privacy",MyModel);
        }
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
