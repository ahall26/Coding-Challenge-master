using ClarkCodingChallenge.Models;
using ClarkCodingChallenge.DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClarkCodingChallenge.Controllers
{
    public class ContactsController : Controller
    {
        private ContactsDataAccess db = new ContactsDataAccess();

        public IActionResult Index()
        {
            return View();
        }


        // GET: Contact/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Contact/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Contact contact)
        {
            if (ModelState.IsValid)
            {
                db.Add(contact);
            }


             return RedirectToAction(nameof(Index));
 
        }


        // GET: Contact/List
        public ActionResult List()
        {
            return View(db.Contacts);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
