namespace EasyMeets.Emailer.WebAPI.Services.Interfaces
{
    public interface IEmailService
    {
        Task<string> SendEmail(string recipient, string body, string subject);
    }
}
