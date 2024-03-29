﻿using Laboratorium_3___App.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Laboratorium_3___App.Controllers
{
    public class ContactController : Controller
    {

        private readonly IContactService _contactService;
        // list of contacts
        //static Dictionary<int, Contact> _contacts = new Dictionary<int, Contact>();
        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }


        [Authorize(Roles = "user, admin")]
        public IActionResult Index()
        {
            return View(_contactService.FindAll());
        }

        [Authorize(Roles = "user, admin")]
        public IActionResult PagedIndex(int page = 1, int size = 5)
        {
            if (size < 2)
                return BadRequest();
            return View(_contactService.FindPage(page, size));
        }

        [Authorize(Roles = "admin")]
        [HttpGet]
        public IActionResult Create()
        {
            Contact model = new Contact();
            model.Organizations = _contactService
                .FindAllOrganizations()
                .Select(o => new SelectListItem() { Value = o.Id.ToString(), Text = o.Title })
                .ToList();
            
            return View(model);
        }

        [Authorize(Roles = "admin")]
        [HttpPost]
        public IActionResult Create(Contact model)
        {
            //if (ModelState.IsValid)
            //{
            //    _contactService.Add(model);
            //    return RedirectToAction("Index");
            //}
            
            //return View(model);
            if (ModelState.IsValid)
            {
                _contactService.Add(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [Authorize(Roles = "admin")]
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

        [Authorize(Roles = "admin")]
        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(_contactService.FindById(id));
        }

        [Authorize(Roles = "admin")]
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

        [Authorize(Roles = "admin")]
        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(_contactService.FindById(id));
        }

        [Authorize(Roles = "admin")]
        [HttpPost]
        public IActionResult Delete(Contact model)
        {
            _contactService.RemoveById(model.ID);
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "user")]
        [HttpGet]
        public IActionResult Details(int id)
        {
            var find = _contactService.FindById(id);
            if(find is null)
                return NotFound();
            return View(find);
        }

        [Authorize(Roles = "user")]
        [HttpPost]
        public IActionResult Details() 
        {
            return RedirectToAction("Index");
        }
    }
}
