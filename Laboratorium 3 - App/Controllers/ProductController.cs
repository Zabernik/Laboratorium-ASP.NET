using Laboratorium_3___App.Models;
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

        public IActionResult Index()
        {
            return View(_productService.FindAll());
        }

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

        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(_productService.FindById(id));
        }

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

        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(_productService.FindById(id));
        }

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

        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(_productService.FindById(id));
        }
        [HttpPost]
        public IActionResult Details()
        {
            return RedirectToAction("Index");
        }
    }
}
