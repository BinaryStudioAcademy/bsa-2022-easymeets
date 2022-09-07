using EasyMeets.Emailer.WebAPI.Services.Interfaces;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Model;

namespace EasyMeets.Emailer.WebAPI.Services
{
    public class EmailService : IEmailService
    {
        private readonly string _senderEmail;
        private readonly string _senderName;
        private readonly ILogger<EmailService> _logger;
        private readonly TransactionalEmailsApi _api;

        public EmailService(IConfiguration configuration, ILogger<EmailService> logger)
        {
            _senderEmail = configuration["Sender:Email"];
            _senderName = configuration["Sender:Name"];
            _logger = logger;
            _api = new TransactionalEmailsApi();
        }

        public async Task<string> SendEmailAsync(string recipient, string body, string subject)
        {
            var email = new SendSmtpEmailSender(_senderName, _senderEmail);
            var smtpEmailTo = new SendSmtpEmailTo(recipient);
            var recipients = new List<SendSmtpEmailTo> { smtpEmailTo };
            try
            {
                var sendSmtpEmail = new SendSmtpEmail(email, recipients, null, null, null, body, subject);
                var result = await _api.SendTransacEmailAsync(sendSmtpEmail);

                return result.MessageId;
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Email wasn't sent");
                throw;
            }
        }
    }
}
