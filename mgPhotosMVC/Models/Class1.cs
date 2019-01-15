using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace mgPhotosMVC.Models
{
    public class User
    {
        public string Name { get; set; }
        public MailAddress Address { get; set; }
        public DateTime BirthDate { get; set; }

        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string Email { get; set; }
    }
}