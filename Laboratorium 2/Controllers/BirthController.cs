using Laboratorium_2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Laboratorium_2.Controllers
{
    public class BirthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult FormBirth()
        {
            return View();
        }
        public IActionResult Hello(Birth model)
        {
            if (model.IsValid())
            {
                return View(model);
            }
            else
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
        }
    }
}
