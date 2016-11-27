using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryWebApplication.Dtos
{
    public class UserDto
    {
        public int Id { get; set; }
       
        public string Username { get; set; }

        public string Password { get; set; }

        public string ConfirmedPassword { get; set; }
    }
}