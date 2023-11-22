﻿using Laboratorium_3___App.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Laboratorium_3___App.Controllers
{
    [Authorize(Roles = "admin")]
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

        [HttpGet]
        public IActionResult Create()
        {
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
            model.Organizations = _contactService
                .FindAllOrganizations()
                .Select(o => new SelectListItem() { Value = o.Id.ToString(), Text = o.Title })
                .ToList();
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
    }
}
