using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LibraryWebApplication.Models
{
    public class Book
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MinLength(2), MaxLength(60), Required]
        public string Name { get; set; }

        [MinLength(2), MaxLength(50)]
        public string Author { get; set; }

        [Required]
        public byte[] CoverPicture { get; set; }

        [Required, MaxLength(1024*1024)]
        public Genre Genre { get; set; }
    }

    public enum Genre
    {
        Fiction,
        Satire,
        Drama,
        Adventure,
        Romance,
        Mystery,
        Horror
    }
}