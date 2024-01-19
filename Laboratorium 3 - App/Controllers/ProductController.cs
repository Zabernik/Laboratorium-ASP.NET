using Laboratorium_3___App.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Laboratorium_3___App.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View(_productService.FindAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            Product model = new Product();
            model.Producers = _productService
                .FindAllProducers()
                .Select(x => new SelectListItem() { Text = x.Name })
                .ToList();
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(Product model)
        {
            if (ModelState.IsValid)
            {
                _productService.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(_productService.FindById(id));
        }

        [HttpPost]
        public IActionResult Update(Product model)
        {
            if (ModelState.IsValid)
            {
                _productService.Update(model);
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
        public IActionResult Delete(Product model)
        {
            _productService.RemoveById(model.Id);
            return RedirectToAction("Index");
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