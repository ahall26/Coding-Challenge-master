using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClarkCodingChallenge.Controllers;
using ClarkCodingChallenge.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ClarkCodingChallenge.Controllers.Tests
{
    [TestClass()]
    public class MailingListControllerTests
    {
        [TestMethod()]
        public void GetTest()
        {
            var controller = new MailingListController();

            IEnumerable<Contact> result = controller.Get("Poe");

            foreach(Contact c in result)
            {
                Assert.AreEqual("Poe", c.LastName);
            }
        }
    }
}