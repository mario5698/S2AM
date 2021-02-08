using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiFlutter.Data;
using WebApiFlutter.Models;

namespace WebApiFlutter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RidersController : ControllerBase
    {
        private readonly WebApiFlutterContext _context;

        public RidersController(WebApiFlutterContext context)
        {
            _context = context;
        }

        // GET: api/Riders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Riders>>> GetRider()
        {
            return await _context.Riders.ToListAsync();
        }

        // GET: api/Riders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Riders>> GetRiders(int id)
        {
            var riders = await _context.Riders.FindAsync(id);

            if (riders == null)
            {
                return NotFound();
            }

            return riders;
        }

        // PUT: api/Riders/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRiders(int id, Riders riders)
        {
            if (id != riders.Id)
            {
                return BadRequest();
            }

            _context.Entry(riders).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RidersExists(id))
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

        // POST: api/Riders
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Riders>> PostRiders(Riders riders)
        {
            _context.Riders.Add(riders);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRiders", new { id = riders.Id }, riders);
        }

        // DELETE: api/Riders/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Riders>> DeleteRiders(int id)
        {
            var riders = await _context.Riders.FindAsync(id);
            if (riders == null)
            {
                return NotFound();
            }

            _context.Riders.Remove(riders);
            await _context.SaveChangesAsync();

            return riders;
        }

        private bool RidersExists(int id)
        {
            return _context.Riders.Any(e => e.Id == id);
        }
    }
}
