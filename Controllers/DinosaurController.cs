using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DinoWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class DinosaurController : ControllerBase
    {
        private readonly DataContext _context;

        public DinosaurController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<List<Dinosaur>>> AddCharacter(Dinosaur character)
        {
            _context.Dinosaurs.Add(character);
            await _context.SaveChangesAsync();

            return Ok(await _context.Dinosaurs.ToListAsync());
        }

        [HttpGet]
        public async Task<ActionResult<List<Dinosaur>>> GetAllCharacters()
        {
            return Ok(await _context.Dinosaurs.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Dinosaur>> GetCharacter(int id)
        {
            var character = await _context.Dinosaurs.FindAsync(id);
            if (character == null)
            {
                return BadRequest("Character not found.");
            }
            return Ok(character);
        }
    }
}