using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using LibraryWebApplication.Utility;

namespace LibraryWebApplication.Dtos
{
    public class UserDto
    {
        private string password;
        private string confirmedPassword;
        public int Id { get; set; }

        public string Username { get; set; }


        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        [Display(Name = "Confirm password")]

        public string ConfirmedPassword { get; set; }
    }
}