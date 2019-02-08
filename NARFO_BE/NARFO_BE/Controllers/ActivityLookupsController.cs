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
    public class ActivityLookupsController : ControllerBase
    {
        private readonly narfoContext _context;

        public ActivityLookupsController(narfoContext context)
        {
            _context = context;
        }

        // GET: api/ActivityLookups
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ActivityLookup>>> GetActivityLookup()
        {
            return await _context.ActivityLookup.ToListAsync();
        }

        // GET: api/ActivityLookups/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ActivityLookup>> GetActivityLookup(int id)
        {
            var activityLookup = await _context.ActivityLookup.FindAsync(id);

            if (activityLookup == null)
            {
                return NotFound();
            }

            return activityLookup;
        }

        // PUT: api/ActivityLookups/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutActivityLookup(int id, ActivityLookup activityLookup)
        {
            if (id != activityLookup.ActivityLookupId)
            {
                return BadRequest();
            }

            _context.Entry(activityLookup).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ActivityLookupExists(id))
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

        // POST: api/ActivityLookups
        [HttpPost]
        public async Task<ActionResult<ActivityLookup>> PostActivityLookup(ActivityLookup activityLookup)
        {
            _context.ActivityLookup.Add(activityLookup);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetActivityLookup", new { id = activityLookup.ActivityLookupId }, activityLookup);
        }

        // DELETE: api/ActivityLookups/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ActivityLookup>> DeleteActivityLookup(int id)
        {
            var activityLookup = await _context.ActivityLookup.FindAsync(id);
            if (activityLookup == null)
            {
                return NotFound();
            }

            _context.ActivityLookup.Remove(activityLookup);
            await _context.SaveChangesAsync();

            return activityLookup;
        }

        private bool ActivityLookupExists(int id)
        {
            return _context.ActivityLookup.Any(e => e.ActivityLookupId == id);
        }
    }
}
