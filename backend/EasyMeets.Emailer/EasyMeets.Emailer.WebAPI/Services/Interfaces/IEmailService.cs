namespace EasyMeets.Emailer.WebAPI.Services.Interfaces
{
    public interface IEmailService
    {
        Task<string> SendEmailAsync(string recipient, string body, string subject);
    }
}
