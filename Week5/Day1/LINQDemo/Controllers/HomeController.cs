using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LINQDemo.Models;

namespace LINQDemo.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    public static Game[] AllGames = new Game[] {
        new Game {Title="Elden Ring", Price=59.99, Genre="Action RPG", Rating="M", Platform="PC"},
        new Game {Title="League of Legends", Price=0.00, Genre="MOBA", Rating="T", Platform="PC"},
        new Game {Title="World of Warcraft", Price=39.99, Genre="MMORPG", Rating="T", Platform="PC"},
        new Game {Title="Elder Scrolls Online", Price=14.99, Genre="Action RPG", Rating="M", Platform="PC"},
        new Game {Title="God of War", Price=99.99, Genre="Action-adventure ", Rating="M", Platform="PC"},
        new Game {Title="Smite", Price=0.00, Genre="MOBA", Rating="T", Platform="All"},
        new Game {Title="Overwatch", Price=39.00, Genre="First-person Shooter", Rating="T", Platform="PC"},
        new Game {Title="Scarlet Nexus", Price=59.99, Genre="Action JRPG", Rating="T", Platform="All"},
        new Game {Title="Wonderlands", Price=59.99, Genre="RPG FPS", Rating="M", Platform="All"},
        new Game {Title="Rocket League", Price=0.00, Genre="Sports", Rating="E", Platform="All"},
        new Game {Title="StarCraft", Price=0.00, Genre="RTS", Rating="T", Platform="PC"},
        new Game {Title="God of War", Price=29.99, Genre="Action-adventure ", Rating="M", Platform="PC"},
        new Game{Title="Doki Doki Literature Club Plus!", Price=10.00, Genre="Casual", Rating="E", Platform="PC"},
        new Game {Title="Red Dead Redemption", Price=40.00, Genre="Action adventure", Rating="M", Platform="All"},
        new Game {Title="Zy Little Pony A Maretime Bay Adventure", Price=39.99, Genre="Adventure", Rating="E",Platform="All"},
        new Game {Title="Fallout New Vegas", Price=10.00, Genre="Open World RPG", Rating="M", Platform="PC"}
    };


    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // this get all the data from our fake database
        List<Game> AllGamesFromData = AllGames.ToList();
        ViewBag.allGames = AllGamesFromData; 

        // Get all the games on all platforms
        List<Game> allPlatforms = AllGames.Where(g => g.Platform == "All").ToList();
        ViewBag.GamesInPlatform = allPlatforms;

        // Get all the data that the Rating is M with the order prices
        List<Game> TopGames = AllGames.Where(m => m.Rating == "M").OrderBy(q => q.Price).ToList();
        ViewBag.TopGames = TopGames;
        // Get All the data order by Title 
        List<Game> TitledGame = AllGames.OrderBy(s => s.Title).ToList();
        ViewBag.TitledGame = TitledGame;
        // Get one Game 
        Game singleGame = AllGames.FirstOrDefault(e => e.Title == "God of War");
        ViewBag.singleGame = singleGame;
        // All games in All platforms with Rating M
        List<Game> AllPlatforGamesWithRatingM = AllGames.Where(f => f.Platform == "All" && f.Rating == "M").ToList();
        ViewBag.AllPlatforGamesWithRatingM = AllPlatforGamesWithRatingM;
        // All Top 3 Games that has the most expecive Prices
        List<Game> Top3Games = AllGames.OrderByDescending(a => a.Price).Take(3).ToList();
        ViewBag.Top3Games = Top3Games;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
