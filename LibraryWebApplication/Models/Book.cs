using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Web;

namespace LibraryWebApplication.Models
{
    public class Book
    {
        private byte[] coverPictureBytes;

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MinLength(2), MaxLength(60), Required]
        public string Name { get; set; }

        [MinLength(2), MaxLength(50)]
        public string Author { get; set; }

        [NotMapped]
        public HttpPostedFileBase CoverPicture { get; set; }

        //[Required, MaxLength(1024 * 1024)]
        public byte[] CoverPictureBytes {
            get { return this.coverPictureBytes; }
            set { this.coverPictureBytes = this.ConvertToByteArray(this.CoverPicture); }
        }

        [Required, Range(1,int.MaxValue)]
        public int PageCount { get; set; }

        [Required]
        public Genre Genre { get; set; }

        private byte[] ConvertToByteArray(HttpPostedFileBase file)
        {
            byte[] data;
            using (Stream inputStream = file.InputStream)
            {
                MemoryStream memoryStream = inputStream as MemoryStream;
                if (memoryStream == null)
                {
                    memoryStream = new MemoryStream();
                    inputStream.CopyTo(memoryStream);
                }

                data = memoryStream.ToArray();
            }

            return data;
        }
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