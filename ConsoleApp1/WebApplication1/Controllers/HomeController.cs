using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult AboutMe()
    {
        return View();
    }
    public IActionResult Skills()
    {
        return View();
    }
    public IActionResult Projects()
    {
        return View();
    }
    public IActionResult Contacts()
    {
        return View();
    }

}