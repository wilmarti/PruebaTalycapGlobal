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
    public class LugarEntregaController : ControllerBase
    {
        private readonly AplicationDbContext _context;

        public LugarEntregaController(AplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/LugarEntrega
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LugarEntrega>>> GetLugarEntrega()
        {
            return await _context.LugarEntrega.ToListAsync();
        }

        // GET: api/LugarEntrega/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LugarEntrega>> GetLugarEntrega(int id)
        {
            var lugarEntrega = await _context.LugarEntrega.FindAsync(id);

            if (lugarEntrega == null)
            {
                return NotFound();
            }

            return lugarEntrega;
        }

        // PUT: api/LugarEntrega/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLugarEntrega(int id, LugarEntrega lugarEntrega)
        {
            if (id != lugarEntrega.IdLugarEntrega)
            {
                return BadRequest();
            }

            _context.Entry(lugarEntrega).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LugarEntregaExists(id))
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

        // POST: api/LugarEntrega
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<LugarEntrega>> PostLugarEntrega(LugarEntrega lugarEntrega)
        {
            _context.LugarEntrega.Add(lugarEntrega);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLugarEntrega", new { id = lugarEntrega.IdLugarEntrega }, lugarEntrega);
        }

        // DELETE: api/LugarEntrega/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<LugarEntrega>> DeleteLugarEntrega(int id)
        {
            var lugarEntrega = await _context.LugarEntrega.FindAsync(id);
            if (lugarEntrega == null)
            {
                return NotFound();
            }

            _context.LugarEntrega.Remove(lugarEntrega);
            await _context.SaveChangesAsync();

            return lugarEntrega;
        }

        private bool LugarEntregaExists(int id)
        {
            return _context.LugarEntrega.Any(e => e.IdLugarEntrega == id);
        }
    }
}
