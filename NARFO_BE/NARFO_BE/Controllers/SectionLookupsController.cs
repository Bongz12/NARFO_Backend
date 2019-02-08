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
    public class SectionLookupsController : ControllerBase
    {
        private readonly narfoContext _context;

        public SectionLookupsController(narfoContext context)
        {
            _context = context;
        }

        // GET: api/SectionLookups
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SectionLookup>>> GetSectionLookup()
        {
            return await _context.SectionLookup.ToListAsync();
        }

        // GET: api/SectionLookups/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SectionLookup>> GetSectionLookup(int id)
        {
            var sectionLookup = await _context.SectionLookup.FindAsync(id);

            if (sectionLookup == null)
            {
                return NotFound();
            }

            return sectionLookup;
        }

        // PUT: api/SectionLookups/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSectionLookup(int id, SectionLookup sectionLookup)
        {
            if (id != sectionLookup.SectionLookUpId)
            {
                return BadRequest();
            }

            _context.Entry(sectionLookup).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SectionLookupExists(id))
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

        // POST: api/SectionLookups
        [HttpPost]
        public async Task<ActionResult<SectionLookup>> PostSectionLookup(SectionLookup sectionLookup)
        {
            _context.SectionLookup.Add(sectionLookup);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSectionLookup", new { id = sectionLookup.SectionLookUpId }, sectionLookup);
        }

        // DELETE: api/SectionLookups/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SectionLookup>> DeleteSectionLookup(int id)
        {
            var sectionLookup = await _context.SectionLookup.FindAsync(id);
            if (sectionLookup == null)
            {
                return NotFound();
            }

            _context.SectionLookup.Remove(sectionLookup);
            await _context.SaveChangesAsync();

            return sectionLookup;
        }

        private bool SectionLookupExists(int id)
        {
            return _context.SectionLookup.Any(e => e.SectionLookUpId == id);
        }
    }
}
