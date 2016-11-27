using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LibraryWebApplication.Attributes;
using LibraryWebApplication.Utility;

namespace LibraryWebApplication.Models
{
    public class User
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MinLength(5), MaxLength(20), Required]
        [Index(IsUnique = true)]
        public string Username { get; set; }

        //[Required, Password(6, 50, ShouldContainLowercase = true, ShouldContainDigit = true, ShouldContainSpecialSymbol = false, ShouldContainUppercase = true)]
        public string Password { get; set; }

    }
}