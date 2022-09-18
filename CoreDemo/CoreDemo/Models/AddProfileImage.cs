using Microsoft.AspNetCore.Http;

namespace CoreDemo.Models
{
    public class AddProfileImage
    {
        public int AuthorID { get; set; }

        public string AuthorName { get; set; }

        public string AuthorAbout { get; set; }

        public IFormFile AuthorImage { get; set; }
        public string AuthorMail { get; set; }

        public string AuthorPassword { get; set; }

        public bool AuthorStatus { get; set; }
    }   
}
