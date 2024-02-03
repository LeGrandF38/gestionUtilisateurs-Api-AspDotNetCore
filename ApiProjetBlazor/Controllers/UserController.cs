using ApiProjetBlazor.Data;
using ApiProjetBlazor.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiProjetBlazor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
        
    {
        private readonly DataContext _context;

        public UserController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<User>>> GetAllUsers()
        {
            var users = await _context.Users.ToListAsync();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return BadRequest("Utilisateur introvable!!!");
            }
            return Ok(user);
        }
        [HttpPost]
        public async Task<ActionResult<List<User>>> AddUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
                ;
            return Ok(await _context.Users.ToListAsync());
        }
        [HttpPut]
        public async Task<ActionResult<List<User>>> UpdateUser(User updatedUser)
        {
            var dbUser = await _context.Users.FindAsync(updatedUser.Id);
            if (dbUser == null)
            {
                return BadRequest("Utilisateur introvable!!!");
            }
            dbUser.Username = updatedUser.Username;
            dbUser.FirstName = updatedUser.FirstName;
            dbUser.LastName = updatedUser.LastName;
            await _context.SaveChangesAsync();
            return Ok(await _context.Users.ToListAsync());
        }

        [HttpDelete]
        public async Task<ActionResult<List<User>>> DeleteUser(int id)
        {
            var dbUser = await _context.Users.FindAsync(id);
            if (dbUser == null)
            {
                return BadRequest("Utilisateur introvable!!!");
            }
            _context.Users.Remove(dbUser);
            await _context.SaveChangesAsync();
            return Ok(await _context.Users.ToListAsync());
        }
    }
}
