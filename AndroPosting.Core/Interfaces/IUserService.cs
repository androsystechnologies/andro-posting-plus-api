using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndroPosting.Core.Interfaces
{
    internal interface IUserService
    {
        void Register(string email, string password);
    }
}
