using AndroPosting.Core.Entities;
using AndroPosting.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace AndroPosting.Infrastructure.Services
{
    public class UserService
    {
        IEmailService _emailService;
        DbContext _dbContext;
        private ILoggerService _loggerService;
        public UserService(IEmailService aEmailService, DbContext aDbContext, ILoggerService aLoggerService)
        {
            _emailService = aEmailService;
            _dbContext = aDbContext;
            _loggerService = aLoggerService;
        }
       
        public void Register(string email, string password)
        {
            try
            {
                if (!_emailService.ValidateEmail(email))
                    throw new ValidationException("Email is not an email");
                var user =new AppUser { UserName=email, Password = password};
                _dbContext.Add(user);
                _dbContext.SaveChanges();
                _emailService.SendEmail(new MailMessage("myname@mydomain.com", email) { Subject = "Hi. How are you!" });
            }
            catch (Exception ex)
            {
                _loggerService.LogMessage(ex.Message);
            }
            
        }
    }
}
