using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BackEnd;
using BackEnd.Models;

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoEnvioController : ControllerBase
    {
        private readonly AplicationDbContext _context;

        public TipoEnvioController(AplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/TipoEnvio
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoEnvio>>> GetTipoEnvio()
        {
            return await _context.TipoEnvio.ToListAsync();
        }

        // GET: api/TipoEnvio/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TipoEnvio>> GetTipoEnvio(int id)
        {
            var tipoEnvio = await _context.TipoEnvio.FindAsync(id);

            if (tipoEnvio == null)
            {
                return NotFound();
            }

            return tipoEnvio;
        }

        // PUT: api/TipoEnvio/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipoEnvio(int id, TipoEnvio tipoEnvio)
        {
            if (id != tipoEnvio.IdTipoEnvio)
            {
                return BadRequest();
            }

            _context.Entry(tipoEnvio).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoEnvioExists(id))
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

        // POST: api/TipoEnvio
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TipoEnvio>> PostTipoEnvio(TipoEnvio tipoEnvio)
        {
            _context.TipoEnvio.Add(tipoEnvio);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTipoEnvio", new { id = tipoEnvio.IdTipoEnvio }, tipoEnvio);
        }

        // DELETE: api/TipoEnvio/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TipoEnvio>> DeleteTipoEnvio(int id)
        {
            var tipoEnvio = await _context.TipoEnvio.FindAsync(id);
            if (tipoEnvio == null)
            {
                return NotFound();
            }

            _context.TipoEnvio.Remove(tipoEnvio);
            await _context.SaveChangesAsync();

            return tipoEnvio;
        }

        private bool TipoEnvioExists(int id)
        {
            return _context.TipoEnvio.Any(e => e.IdTipoEnvio == id);
        }
    }
}
