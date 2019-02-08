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
    public class ApplicationLookupsController : ControllerBase
    {
        private readonly narfoContext _context;

        public ApplicationLookupsController(narfoContext context)
        {
            _context = context;
        }

        // GET: api/ApplicationLookups
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ApplicationLookup>>> GetApplicationLookup()
        {
            return await _context.ApplicationLookup.ToListAsync();
        }

        // GET: api/ApplicationLookups/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ApplicationLookup>> GetApplicationLookup(int id)
        {
            var applicationLookup = await _context.ApplicationLookup.FindAsync(id);

            if (applicationLookup == null)
            {
                return NotFound();
            }

            return applicationLookup;
        }

        // PUT: api/ApplicationLookups/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutApplicationLookup(int id, ApplicationLookup applicationLookup)
        {
            if (id != applicationLookup.AppLookupId)
            {
                return BadRequest();
            }

            _context.Entry(applicationLookup).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ApplicationLookupExists(id))
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

        // POST: api/ApplicationLookups
        [HttpPost]
        public async Task<ActionResult<ApplicationLookup>> PostApplicationLookup(ApplicationLookup applicationLookup)
        {
            _context.ApplicationLookup.Add(applicationLookup);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetApplicationLookup", new { id = applicationLookup.AppLookupId }, applicationLookup);
        }

        // DELETE: api/ApplicationLookups/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApplicationLookup>> DeleteApplicationLookup(int id)
        {
            var applicationLookup = await _context.ApplicationLookup.FindAsync(id);
            if (applicationLookup == null)
            {
                return NotFound();
            }

            _context.ApplicationLookup.Remove(applicationLookup);
            await _context.SaveChangesAsync();

            return applicationLookup;
        }

        private bool ApplicationLookupExists(int id)
        {
            return _context.ApplicationLookup.Any(e => e.AppLookupId == id);
        }
    }
}
