using Laboratorium_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Laboratorium_1.Controllers
{
    public enum Operators
    {
        add,
        sub,
        mul,
        div
    }

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

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
        public IActionResult About(string author, int? id)
        {
            //string author = Request.Query["author"];
            //string strid = Request.Query["id"];
            //if (int.TryParse(strid, out var id))
            //{
            //    ViewBag.Author = $"{author} + id = {id}";
            //}
            //else
            //{
            //    ViewBag.Author = author;
            //}
            if (author is null || id is null)
            {
                return BadRequest();
            }
            ViewBag.Author = $"{author} id = {id}";
            return View();
        }
        public IActionResult Calculator(string op, double dig1, double dig2)
        {
            double result = 0;
            switch (op)
            {
                case "add":
                    result = dig1 + dig2;
                    break;
                case "sub":
                    result = dig1 - dig2;
                    break;
                case "mul":
                    result = dig1 * dig2;
                    break;
                case "div":
                    result = dig1 / dig2;
                    break;
            }
            if (op is null || (dig1 == 0 && dig2 == 0))
            {
                ViewBag.Result = "Brak dzialania na kalkulatorze";
            }
            else
            {
                ViewBag.Result = $"Wynik dzialania {op} liczb {dig1} oraz {dig2} to {result}";
            }

            return View();
        }

        public IActionResult Kalkulator([FromQuery(Name = "operator")] Operators? op, double? x, double? y)
        {
            if(op == null || x == null || y == null)
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}