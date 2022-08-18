using EasyMeets.Emailer.Services.Interfaces;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace EasyMeets.Emailer.Services
{
    public class EmailService : IEmailService
    {
        private readonly string _apiKey;
        private readonly ILogger<EmailService> _logger;

        public EmailService(IConfiguration configuration, ILogger<EmailService> logger)
        {
            _apiKey = configuration["Sendinblue:ApiKey"];
            _logger = logger;
        }

        public async Task<string> SendEmail(string recipient, string body, string subject)
        {
            Configuration.Default.ApiKey.Add("api-key", _apiKey);

            var apiInstance = new TransactionalEmailsApi();
            string SenderName = "John Doe";
            string SenderEmail = "easymeetsteam@gmail.com";
            var Email = new SendSmtpEmailSender(SenderName, SenderEmail);
            string ToEmail = recipient;
            var smtpEmailTo = new SendSmtpEmailTo(ToEmail);
            List<SendSmtpEmailTo> To = new ();
            To.Add(smtpEmailTo);
            string TextContent = body;
            string Subject = subject;
            try
            {
                var sendSmtpEmail = new SendSmtpEmail(Email, To, null, null, null, TextContent, Subject);
                CreateSmtpEmail result = await apiInstance.SendTransacEmailAsync(sendSmtpEmail);

                return result.MessageId;
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Email wasn't sent");
                return string.Empty;
            }
        }
    }
}
