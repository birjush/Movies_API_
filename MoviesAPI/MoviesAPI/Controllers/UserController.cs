using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesAPI.Data;
using MoviesAPI.Models;

namespace MoviesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext db;
        public UserController(ApplicationDbContext _db)
        {
            this.db = _db;
        }
        /*[HttpPost]
        public async Task<ActionResult<User>> CreateUser(User obj)
        {
            obj.Key = Guid.NewGuid().ToString();
            await db.users.AddAsync(obj);
            await db.SaveChangesAsync();
            return Ok(obj.Key);
        }*/
        [HttpPost("Authenticate")]
        public async Task<ActionResult<User>> Authenticate([FromBody] User obj)
        {
            if (obj == null)
                return BadRequest();

            var user = db.users.FirstOrDefault(
                x=>x.Email == obj.Email && x.Password==obj.Password);

            if (user == null)
                return NotFound(new { msg = "Email Or Password Incorrecrt!" });

            return Ok(new { msg = "Login Succesfull!", key=obj.Key, 
                url="/"+obj.Key });
        }

        [HttpPost("Register")]
        public async Task<ActionResult<User>> RegisterUser([FromBody] User obj)
        {
            if (obj == null)
                return BadRequest();
            obj.Key = Guid.NewGuid().ToString();
            await db.users.AddAsync(obj);
            await db.SaveChangesAsync();
            return Ok(new {msg="Registered Succesfully!"});

        }
       /* [HttpPost("Register")]
        public async Task<ActionResult<User>> RegisterUser(string key,string email,string password)
        {
            User obj = new User();
            if (obj == null)
                return BadRequest();
            obj.Key = Guid.NewGuid().ToString();
            obj.Email = email;
            obj.Password = password;
            await db.users.AddAsync(obj);
            await db.SaveChangesAsync();
            return Ok(new { msg = "Registered Succesfully!" });

        }*/


        [HttpGet]
        public async Task<ActionResult<List<User>>> GetAllUsers()
        {
            var data = await db.users.ToListAsync();
            return Ok(data);
        }
    }
}
