using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClarkCodingChallenge.Controllers;
using ClarkCodingChallenge.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace ClarkCodingChallenge.Tests.ControllerTest
{
    [TestClass]
    public class ContactsControllerTests
    {
        [TestMethod]
        public void TestListView()
        {
            ContactsController controller = new ContactsController();
            ViewResult result = controller.List() as ViewResult;

            IEnumerable<Contact> contacts = (IEnumerable<Contact>)result.ViewData.Model;

            Assert.AreEqual(4, ((List<Contact>)contacts).Count);


        }
    }
}
