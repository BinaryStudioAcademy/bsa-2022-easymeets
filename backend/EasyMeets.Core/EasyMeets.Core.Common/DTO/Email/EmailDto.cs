namespace EasyMeets.Core.Common.DTO
{
    public class EmailDto
    {
        public string Body { get; set; } = null!;
        public string Subject { get; set; } = null!;
        public string Recipient { get; set; } = null!;
    }
}
