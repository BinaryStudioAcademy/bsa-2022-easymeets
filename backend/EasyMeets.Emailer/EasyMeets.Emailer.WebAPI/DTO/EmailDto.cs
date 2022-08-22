using System.ComponentModel.DataAnnotations;

namespace EasyMeets.Emailer.WebAPI.DTO
{
    public class EmailDto
    {
        [Required]
        public string Body { get; set; }
        public string Subject { get; set; }
        [Required]
        [EmailAddress]
        public string Recipient { get; set; }
    }
}
