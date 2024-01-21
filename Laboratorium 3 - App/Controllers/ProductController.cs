using Laboratorium_3___App.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Laboratorium_3___App.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [Authorize(Roles = "user, admin")]
        public IActionResult Index()
        {
            return View(_productService.FindAll());
        }

        [Authorize(Roles = "admin")]
        [HttpGet]
        public IActionResult Create()
        {
            Product prod = new Product();
            prod.Producers = _productService
                .FindAllProducers()
                .Select(o => new SelectListItem() { Text = o.Name })
                .ToList();
            return View(prod);
        }

        [Authorize(Roles = "admin")]
        [HttpPost]
        public IActionResult Create(Product prod)
        {
            if (ModelState.IsValid)
            {
                _productService.Add(prod);
                return RedirectToAction("Index");
            }
            else
            {
                return View(prod);
            }
        }

        [Authorize(Roles = "admin")]
        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(_productService.FindById(id));
        }

        [Authorize(Roles = "admin")]
        [HttpPost]
        public IActionResult Update(Product prod)
        {
            if (ModelState.IsValid)
            {
                _productService.Update(prod);
                return RedirectToAction("Index");
            }
            return View();
        }

        [Authorize(Roles = "admin")]
        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(_productService.FindById(id));
        }

        [Authorize(Roles = "admin")]
        [HttpPost]
        public IActionResult Delete(Product prod, string submitAction)
        {
            if (submitAction == "Tak")
            {
                _productService.RemoveById(prod.Id);
                return RedirectToAction("Index");
            }
            else if (submitAction == "Nie")
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        [Authorize(Roles = "user, admin")]
        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(_productService.FindById(id));
        }

        [Authorize(Roles = "user, admin")]
        [HttpPost]
        public IActionResult Details()
        {
            return RedirectToAction("Index");
        }
    }
}
