using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Videolocadora.Model;

namespace Videolocadora.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmesAtributosController : ControllerBase
    {
        private readonly FilmesContext _context;

        public FilmesAtributosController(FilmesContext context)
        {
            _context = context;
        }

        // GET: api/FilmesAtributos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FilmesAtributos>>> GetFilmesAtributos()
        {
            return await _context.FilmesAtributos.ToListAsync();
        }

        // GET: api/FilmesAtributos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FilmesAtributos>> GetFilmesAtributos(int id)
        {
            var filmesAtributos = await _context.FilmesAtributos.FindAsync(id);

            if (filmesAtributos == null)
            {
                return NotFound();
            }

            return filmesAtributos;
        }

        // PUT: api/FilmesAtributos/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFilmesAtributos(int id, FilmesAtributos filmesAtributos)
        {
            if (id != filmesAtributos.codFilme)
            {
                return BadRequest();
            }

            _context.Entry(filmesAtributos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FilmesAtributosExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/FilmesAtributos
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<FilmesAtributos>> PostFilmesAtributos(FilmesAtributos filmesAtributos)
        {
            _context.FilmesAtributos.Add(filmesAtributos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFilmesAtributos", new { id = filmesAtributos.codFilme }, filmesAtributos);
        }

        // DELETE: api/FilmesAtributos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<FilmesAtributos>> DeleteFilmesAtributos(int id)
        {
            var filmesAtributos = await _context.FilmesAtributos.FindAsync(id);
            if (filmesAtributos == null)
            {
                return NotFound();
            }

            _context.FilmesAtributos.Remove(filmesAtributos);
            await _context.SaveChangesAsync();

            return filmesAtributos;
        }

        private bool FilmesAtributosExists(int id)
        {
            return _context.FilmesAtributos.Any(e => e.codFilme == id);
        }
    }
}
