using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EFDemo.Models;

namespace EFDemo.Controllers;

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
    [HttpPost("songs/create")]
    public IActionResult CreatingSong(Song newSong)
    {
        if (ModelState.IsValid)
        {
            _context.Add(newSong);
            _context.SaveChanges();
            return RedirectToAction("AllSongs");
        }
        else
        {
            return View("Index");
        }
    }
    [HttpGet("songs")]
    public IActionResult AllSongs()
    {
        List<Song> AllSongs = _context.Songs.ToList();
        return View("AllSongs",AllSongs);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [HttpPost("songs/destroy")]
    public IActionResult DestroySong(int songId)
    {
        Song? SongToDestroy = _context.Songs.SingleOrDefault(a => a.SongId == songId);
        _context.Songs.Remove(SongToDestroy);
        _context.SaveChanges();
        return RedirectToAction("AllSongs");
    }
    [HttpGet("songs/{songId}/update")]
    public IActionResult EditSong(int songId)
    {
        Song? SongToUpdate = _context.Songs.FirstOrDefault(b => b.SongId == songId);
        return View(SongToUpdate);
    }
    [HttpPost("songs/{songId}/update")]
    public IActionResult UpdatingSong(int songId, Song sonToUp)
    {
        Song? SongToUpdate = _context.Songs.FirstOrDefault(b => b.SongId == songId);
        if (SongToUpdate == null)
        {
            return RedirectToAction("Index");
        }
        if (ModelState.IsValid)
        {
            SongToUpdate.Title = sonToUp.Title;
            SongToUpdate.Year = sonToUp.Year;
            SongToUpdate.Genre = sonToUp.Genre;
            SongToUpdate.UpdatedAt = DateTime.Now;
            _context.SaveChanges();
            return RedirectToAction("AllSongs");
        }
        else
        {
            return View("EditSong", SongToUpdate);
        }
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
