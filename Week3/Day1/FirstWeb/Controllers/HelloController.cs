
using Microsoft.AspNetCore.Mvc; // this is a service that brings in our MVC functionality
namespace FirstWeb.Controllers;


public class HelloController : Controller // remember inheritance
{
    // Routing!!
    // this tells our controller ze have a web page or data we want to see (or GET)
    [HttpGet]
    // What is the url?
    // this gis your URL localhost:5XXXX/
    [Route("")]
    public string Index()
    {
        return "Hello from the server";
    }
    //URL localhost:5XXXX/user:more
    [HttpGet("/user/more")]
    public string AUser()
    {
        return "More users information that we have";
    }
    [HttpGet("/user/data/{id}")]
    public string UserData(int id)
    {
        return $"this is the user Data {id}";
    }

    [HttpGet("/home")]
    public ViewResult Home()
    {
        // ViewBag allows us to pass data from our controller to our View
        // think of view bag as dictionary/props it has keys and value
        // {Name:wael}
        ViewBag.Name = "Wael";
        ViewBag.Number = 6;
        return View("Index");
    }

    [HttpGet("/homeof")]
    public ViewResult Homeof()
    {
        ViewBag.Name = "Dali";
        return View("Aindex");
    }


    
}