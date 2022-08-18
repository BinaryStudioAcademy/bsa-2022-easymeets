namespace EasyMeets.Emailer.Services.Interfaces
{
    public interface IEmailService
    {
        Task<string> SendEmail(string recipient, string body, string subject);
    }
}
