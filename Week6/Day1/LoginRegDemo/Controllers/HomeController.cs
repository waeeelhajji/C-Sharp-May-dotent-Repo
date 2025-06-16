using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LoginRegDemo.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace LoginRegDemo.Controllers;

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
        return View();
    }
    [HttpPost("users/create")]
    public IActionResult CreateUser(User newUser)
    {
        if (ModelState.IsValid)
        {
            // Hash our password
            PasswordHasher<User> Hasher = new PasswordHasher<User>();
            newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
            _context.Add(newUser);
            _context.SaveChanges();
            return RedirectToAction("Success");
        }
        else
        {
            return View("Index");
        }
    }
    [HttpPost("users/login")]
    public IActionResult LoginUser(LogUser loginUser)
    {
        if (ModelState.IsValid)
        {
            // look up for our user in the database
            User? userInDB = _context.Users.FirstOrDefault(u => u.Email == loginUser.LogEmail);
            // we need to verify this is a who exist
            if (userInDB == null)
            {
                ModelState.AddModelError("LogEmail", "Invalid Email/Password");
                return View("Index");
            }
            // Verify the password matches whats in the database
            PasswordHasher<LogUser> Hasher = new PasswordHasher<LogUser>();
            var result = Hasher.VerifyHashedPassword(loginUser, userInDB.Password, loginUser.LogPassword);
            if (result == 0)
            {
                // Afailure, we did not use the righ password
                ModelState.AddModelError("LogEmail", "Invalid Email/Password");
                return View("Index");

            }
            else
            {
                return RedirectToAction("Success");
            }
        }
        else
        {
            return View("Index");
        }
    }

    public IActionResult Success()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
