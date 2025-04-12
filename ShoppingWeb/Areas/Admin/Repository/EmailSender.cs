using System.Net.Mail;
using System.Net;

namespace ShoppingWeb.Areas.Admin.Repository
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string message)
        {
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                EnableSsl = true, //bật bảo mật
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("littlebisu1910@gmail.com", "pdlvuseywhifsfyz")
            };

            return client.SendMailAsync(
                new MailMessage(from: "littlebisu1910@gmail.com",
                                to: email,
                                subject,
                                message

                                ));
        }
    }
}
