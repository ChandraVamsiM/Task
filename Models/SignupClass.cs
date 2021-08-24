using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SignUpForm.Models
{
    public class SignupClass
    {
        public int Userid { get; set; }


        [DisplayName("First Name")]
        [Required(ErrorMessage = "First Name required")]
        public string Firstname { get; set; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Last Name required")]
        public string Lastname { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [Required(ErrorMessage = "Date of Birth required")]
        public string Dateofbirth { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please enter Email ID")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")]
        public string Email { get; set; }

        [DisplayName("Password")]
        [Required(ErrorMessage = "Enter the Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("Confirmpassword")]
        [Required(ErrorMessage = "Confirm the Password")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string Confirmpassword { get; set; }
    }
}