using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using VerifyEmailForgotPassword.Models;

namespace VerifyEmailForgotPassword.Services.EmailService
{
    public interface IEmailService
    {
        void SendEmail(EmailDto request);
        

    }
}
