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
        ViewData["About"]= " I am currently studying Bachelor of Science in Information Technology.\r\n                I enjoy creating desktop and web applications while continuously improving\r\n                my programming skills through school projects and self-learning.";
        ViewData["AboutMe"] = " My goal is to become a full-stack software developer and build systems that\r\n                make people's work easier. While I'm in my free time, I enjoy programming,\r\n                reading, gaming, and learning new technologies.";
        ViewData["Education"] = "BS Information Technolog";
        ViewData["CareerGoal"] = "Full Stack Developer";
        ViewData["Interest"] = "Programming, Reading, Gaming";
        return View();
    }
    public IActionResult Skills()
    {
        ViewData["ProgrammingLanguages"] = "C#, Java, Python, VB.NET";
        ViewData["Web"] = " HTML, CSS, Bootstrap, ASP.NET MVC";
        ViewData["Databases"] = "   MySQL, MS Access";
        ViewData["Tools"] = "Visual Studio, VS Code, Pycharm, GitHub";
        return View();
    }
    public IActionResult Projects()
    {
        ViewData["SalesInventory"] = "Desktop application that manages products, inventory, and sales transactions.";
        ViewData["ParkingManagement"] = "Console-based parking system with receipt generation, and payment computation.";
        ViewData["LoanApplication"] = "A platform that allows users to apply for loans and check their approval status. It computes Interest, Monthly Amortization, and Total Amount Payable.";
        return View();
    }
    public IActionResult Contacts()
    {
        ViewData["Email"] = "rondoloravenjoe@gmail.com";
        ViewData["Mobile"] = "0976-228-6079";
        ViewData["Github"] = "github.com/AlbanoRavenPOGI";
        ViewData["LinkedIn"] = "linkedin.com/in/raven";
        ViewData["Facebook"] = "Raven Alban?o";
        return View();
    }

}