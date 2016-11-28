using System.ComponentModel.DataAnnotations;
using System.Web;
using LibraryWebApplication.Models;

namespace LibraryWebApplication.Dtos
{
    public class BookDto
    { 
        public string Name { get; set; }

        public string Author { get; set; }

        [Display(Name = "Cover Picture")]
        public HttpPostedFileBase CoverPicture { get; set; }

        [Display(Name = "Pages Count")]
        public int PageCount { get; set; }

        public Genre Genre { get; set; }
    }
}