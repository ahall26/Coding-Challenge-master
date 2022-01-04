using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClarkCodingChallenge.Models
{
    public class Contact
    {
        public Contact() { }
        public Contact(String firstName, String lastName, String eMail)
        {
            FirstName = firstName;
            this.LastName = lastName;
            this.EMail = eMail;
        }

        [Required]
        [Display(Name = "First Name")]
        public String FirstName { get; set; }


        [Required]
        [Display(Name = "Last Name")]
        public String LastName { get; set; }


        [Required]
        [Display(Name = "E-Mail Address")]
        [EmailAddress(ErrorMessage = "Invalid E-Mail Address")]
        public String EMail { get; set; }

    }
}
