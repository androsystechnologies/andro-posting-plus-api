using AndroPosting.API.Data;
using AndroPosting.API.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace AndroPosting.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController(DataContext context) : ControllerBase
    {

       [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
              var users=await context.Users.ToListAsync();

              return users;
        }

        [HttpGet("{Id:int}")]
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
             var user= await context.Users.FindAsync(id);

             if(user == null) return NotFound();

           return user;
        }
    }
}
