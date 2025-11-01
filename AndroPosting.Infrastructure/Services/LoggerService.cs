using AndroPosting.Core.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndroPosting.Infrastructure.Services
{
    public class LoggerService:ILoggerService
    {
        public void LogMessage(string aMessage)
        {
            //Code to write message in database.
        }
    }
}
