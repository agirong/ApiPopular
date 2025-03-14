using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiPopular.Data;
using ApiPopular.Models;

namespace ApiPopular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AsesoresController : ControllerBase
    {
        private readonly ApiPopularContext _context;

        public AsesoresController(ApiPopularContext context)
        {
            _context = context;
        }

        // GET: api/Asesores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Asesores>>> GetAsesores()
        {
            return await _context.Asesores.ToListAsync();
        }

        // GET: api/Asesores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Asesores>> GetAsesores(int id)
        {
            var asesores = await _context.Asesores.FindAsync(id);

            if (asesores == null)
            {
                return NotFound();
            }

            return asesores;
        }

        // PUT: api/Asesores/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsesores(int id, Asesores asesores)
        {
            if (id != asesores.CodigoAsesor)
            {
                return BadRequest();
            }

            _context.Entry(asesores).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AsesoresExists(id))
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

        // POST: api/Asesores
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Asesores>> PostAsesores(Asesores asesores)
        {
            _context.Asesores.Add(asesores);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAsesores", new { id = asesores.CodigoAsesor }, asesores);
        }

        // DELETE: api/Asesores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsesores(int id)
        {
            var asesores = await _context.Asesores.FindAsync(id);
            if (asesores == null)
            {
                return NotFound();
            }

            _context.Asesores.Remove(asesores);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AsesoresExists(int id)
        {
            return _context.Asesores.Any(e => e.CodigoAsesor == id);
        }
    }
}
