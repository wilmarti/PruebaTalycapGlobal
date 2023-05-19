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
    public class DespachoController : ControllerBase
    {
        private readonly AplicationDbContext _context;

        public DespachoController(AplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Despacho
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Despacho>>> GetDespacho()
        {
            return await _context.Despacho.ToListAsync();
        }

        // GET: api/Despacho/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Despacho>> GetDespacho(int id)
        {
            var despacho = await _context.Despacho.FindAsync(id);

            if (despacho == null)
            {
                return NotFound();
            }

            return despacho;
        }

        // PUT: api/Despacho/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDespacho(int id, Despacho despacho)
        {
            if (id != despacho.IdDespacho)
            {
                return BadRequest();
            }

            _context.Entry(despacho).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DespachoExists(id))
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

        // POST: api/Despacho
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Despacho>> PostDespacho(Despacho despacho)
        {
            _context.Despacho.Add(despacho);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDespacho", new { id = despacho.IdDespacho }, despacho);
        }

        // DELETE: api/Despacho/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Despacho>> DeleteDespacho(int id)
        {
            var despacho = await _context.Despacho.FindAsync(id);
            if (despacho == null)
            {
                return NotFound();
            }

            _context.Despacho.Remove(despacho);
            await _context.SaveChangesAsync();

            return despacho;
        }

        private bool DespachoExists(int id)
        {
            return _context.Despacho.Any(e => e.IdDespacho == id);
        }
    }
}
