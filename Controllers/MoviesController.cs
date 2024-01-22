using Microsoft.AspNetCore.Mvc;
using Movies.Data;
using Microsoft.EntityFrameworkCore;

namespace Movies.Data
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly MoviesDbContext _context;
        string name="karnisha";
        private readonly int Id;

        public MoviesController(MoviesDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("GetTrainer")]
         public ActionResult<IEnumerable<Movies>>Get ()
         {
            return _context.Movies.ToList();
         }

           // public async Task<ActionResult<int>> GetTrainer(int id)
        // {
        //     return Ok(await _context.Trainers.ToListAsync());
        // }
         

        // [HttpDelete]
        // [Route("id")]

        // public async Task<ActionResult<int>> DeleteTrainer(int id)

        // {
        //     var Trainer = await _context.Trainers.FindAsync(id);


        //     if (Trainer == null)
        //     {
        //         return NotFound("Incorrect Trainee Id");
        //     }


        //     _context.Trainers.Remove(Trainer);
        //     await _context.SaveChangesAsync();

        //     return Ok();
        // }


        // [HttpPut]
        // [Route("id")]

        // public async Task<ActionResult> PutTrainer(Trainer trainer)
        // {
        //     if (id != trainer.Id)
        //     {

        //         return BadRequest();
        //     }
        //     _context.Entry(trainer).State = EntityState.Modified;
        //     await _context.SaveChangesAsync();
        //     return Ok();
        // }


        [HttpPost]
        [Route("Create")]

        public async Task<ActionResult<Movies>> Create(Movies movie)
        {
            _context.Add(movie);

            await _context.SaveChangesAsync();
            return Ok();


        }




    }
}