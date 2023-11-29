using Laboratorium_3___App.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Laboratorium_3___App.Controllers
{
    //[Authorize(Roles = "admin")]
    public class ContactController : Controller
    {

        private readonly IContactService _contactService;
        // list of contacts
        //static Dictionary<int, Contact> _contacts = new Dictionary<int, Contact>();
        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }


        [AllowAnonymous]
        public IActionResult Index()
        {
            return View(_contactService.FindAll());
        }

        public IActionResult PagedIndex(int page = 1, int size = 5)
        {
            if (size < 2)
                return BadRequest();
            return View(_contactService.FindPage(page, size));
        }

        [HttpGet]
        public IActionResult Create()
        {
            //Contact contact = new Contact() { Organizations = _contactService.FindAllOrganizations() };
            return View();
        }

        [HttpPost]
        public IActionResult Create(Contact model)
        {
            if (ModelState.IsValid)
            {
                _contactService.Add(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult CreateApi()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateApi(Contact model)
        {
            if (ModelState.IsValid)
            {
                _contactService.Add(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(_contactService.FindById(id));
        }

        [HttpPost]
        public IActionResult Update(Contact model)
        {
            if (ModelState.IsValid)
            {
                _contactService.Update(model);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(_contactService.FindById(id));
        }

        [HttpPost]
        public IActionResult Delete(Contact model)
        {
            _contactService.RemoveById(model.ID);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(_contactService.FindById(id));
        }
        [HttpPost]
        public IActionResult Details() 
        {
            return RedirectToAction("Index");
        }

        //private List<SelectListItem> CreateList()
        //{
        //    return _contactService.FindAllOrganizations();
        //} nie bedzie dzialac
    }
}
