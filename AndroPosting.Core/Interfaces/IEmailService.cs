using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace AndroPosting.Core.Interfaces
{
    public interface IEmailService
    {
         bool ValidateEmail(string email);
         void SendEmail(MailMessage message);
    }
}
