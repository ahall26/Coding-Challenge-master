using ClarkCodingChallenge.Models;
using System.Collections.Generic;

namespace ClarkCodingChallenge.DataAccess
{

    public class ContactsDataAccess
    {

        private static List<Contact> contacts = new List<Contact> {       
            new Contact("Edgar Allen", "Poe", "eap@sample.test"),
            new Contact("Oscar", "Wilde", "owilde@sample.test"),
            new Contact("Charlotte", "Bronte", "cbronte@sample.test"),
            new Contact("Nathaniel", "Hawthorne", "hawty@sample.test")
        };

        public List<Contact> Contacts
        {
            get { return contacts; }
        }

        public void Add(Contact contact)
        {
            contacts.Add(contact);
        }

    }
}
