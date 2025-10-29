using AndroPosting.Core.Entities;
using System;

namespace AndroPosting.Core.Interfaces;

public interface ITokenService
{
       string CreateToken(AppUser user);
}
