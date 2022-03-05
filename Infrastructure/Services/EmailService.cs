/*using System;
using Core.Interfaces;
using Microsoft.Extensions.Logging;
using MimeKit;
//using MailKit;
using MailKit.Net.Smtp;

namespace Infrastructure.Services
{
    public class EmailService : IEmailService
    {
        //private readonly MailSettings _mailsettings; 
        //private readonly StoreContext _context;
        private readonly ILogger<EmailService> _logger;
        public EmailService(//StoreContext context,
                            ILogger<EmailService> logger)
        {
            //_context = context;
            _logger = logger;
        }

        public bool EamilContactUs(string Name, string Email, string Telephone, string Subject, string Message)
        {
            try 
            {

              

                var email2 = new MimeMessage();
                email2.Sender = MailboxAddress.Parse("martinslater1975@gmail.com");
                email2.To.Add(MailboxAddress.Parse("martin@ms-consultancy.co.uk"));
                email2.Subject = Subject;
                var builder = new BodyBuilder();
                builder.HtmlBody = "Name: " + Name + 
                                   "<br/> Email: " + Email +
                                   "<br/> Telephone: " + Telephone +
                                   "<br/> Message: " + Message;
                email2.Body = builder.ToMessageBody(); 
                

                using var smtp = new SmtpClient();
                smtp.Connect("smtp.gmail.com", 465, MailKit.Security.SecureSocketOptions.SslOnConnect);
                smtp.Authenticate("martinslater1975@gmail.com","qomxu2-copkom-sehwYk");
             
                
              
                smtp.Send(email2);

                return true;

                
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Email error: " + ex.ToString());
                return false;
            }
        }
    }
}*/