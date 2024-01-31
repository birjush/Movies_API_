using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesAPI.Data;
using MoviesAPI.Models;

namespace MoviesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly ApplicationDbContext db;
        public MoviesController(ApplicationDbContext _db)
        {
            this.db = _db;
        }

        [HttpGet("{Key}")]
        public async Task<ActionResult<List<Movies>>> GetAllMovies(string key)
        {
            var exist = db.users.FirstOrDefault(x => x.Key == key);
            if (exist != null)
            {
                if (exist.Key == key)
                {
                    var data = await db.movies.ToListAsync();
                    return Ok(data);
                }
                return BadRequest();
            }
            return Unauthorized();
            }


       /* [HttpGet("{id}")]
        public async Task<ActionResult<Movies>> GetMovieById(int id)
        {
            var movie = await db.movies.FindAsync(id);
            if (movie == null)
                return NotFound();
            return movie;
        }*/
        /*
                [HttpPut("{id}")]
                public async Task<ActionResult<Movies>> UpdateMovie(int id, Movies obj)
                {
                    db.Entry(obj).State = EntityState.Modified;
                    await db.SaveChangesAsync();
                    return Ok(obj);
                }

                [HttpDelete("{id}")]
                public async Task<ActionResult<Movies>> DeleteMovie(int id)
                {
                    var movie = await db.movies.FindAsync(id);
                    if (movie != null)
                    {
                        db.movies.Remove(movie);
                        await db.SaveChangesAsync();
                        return Ok();
                    }
                    return BadRequest();
                }*/
    }
}
