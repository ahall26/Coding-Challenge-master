using ClarkCodingChallenge.Models;
using ClarkCodingChallenge.DataAccess;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClarkCodingChallenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MailingListController : ControllerBase
    {
        private ContactsDataAccess db = new ContactsDataAccess();


        // GET: api/MailingList/
        [HttpGet]
        public IEnumerable<Contact> Get(string LastName = null, bool? desc = false)
        {
            IEnumerable<Contact> results = db.Contacts;

            if (LastName != null)
                results = results.Where(c => c.LastName == LastName);

            if (desc ?? desc is null) // Allows "desc" as shorthand for "desc=True"
                return results.OrderByDescending(c => c.FirstName).OrderByDescending(c => c.LastName);
            else
                return results.OrderBy(c => c.FirstName).OrderBy(c => c.LastName);

        }



    }
}
