using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NARFO_BE.Models;

namespace NARFO_BE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OutletsController : ControllerBase
    {
        private readonly narfoContext _context;

        public OutletsController(narfoContext context)
        {
            _context = context;
        }

        // GET: api/Outlets
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Outlets>>> GetOutlets()
        {
            return await _context.Outlets.ToListAsync();
        }

        // GET: api/Outlets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Outlets>> GetOutlets(int id)
        {
            var outlets = await _context.Outlets.FindAsync(id);

            if (outlets == null)
            {
                return NotFound();
            }

            return outlets;
        }

        // PUT: api/Outlets/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOutlets(int id, Outlets outlets)
        {
            if (id != outlets.Owner)
            {
                return BadRequest();
            }

            _context.Entry(outlets).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OutletsExists(id))
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

        // POST: api/Outlets
        [HttpPost]
        public async Task<ActionResult<Outlets>> PostOutlets(Outlets outlets)
        {
            _context.Outlets.Add(outlets);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (OutletsExists(outlets.Owner))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetOutlets", new { id = outlets.Owner }, outlets);
        }

        // DELETE: api/Outlets/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Outlets>> DeleteOutlets(int id)
        {
            var outlets = await _context.Outlets.FindAsync(id);
            if (outlets == null)
            {
                return NotFound();
            }

            _context.Outlets.Remove(outlets);
            await _context.SaveChangesAsync();

            return outlets;
        }

        private bool OutletsExists(int id)
        {
            return _context.Outlets.Any(e => e.Owner == id);
        }
    }
}
