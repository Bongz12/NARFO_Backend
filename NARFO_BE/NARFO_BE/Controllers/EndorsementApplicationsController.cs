using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NARFO_BE.Models;

namespace NARFO_BE.Controllers
{
    [Route("api/[controller]")]
  [EnableCors("MyPolicy")]
    public class EndorsementApplicationsController : ControllerBase
    {
        private readonly narfoContext _context;

        public EndorsementApplicationsController(narfoContext context)
        {
            _context = context;
        }

        // GET: api/EndorsementApplications
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EndorsementApplication>>> GetEndorsementApplication()
        {
            return await _context.EndorsementApplication.ToListAsync();
        }

        // GET: api/EndorsementApplications/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EndorsementApplication>> GetEndorsementApplication(int id)
        {
            var endorsementApplication = await _context.EndorsementApplication.FindAsync(id);

            if (endorsementApplication == null)
            {
                return NotFound();
            }

            return endorsementApplication;
        }

        // PUT: api/EndorsementApplications/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEndorsementApplication(int id, EndorsementApplication endorsementApplication)
        {
            if (id != endorsementApplication.EndorsAppID)
            {
                return BadRequest();
            }

            _context.Entry(endorsementApplication).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EndorsementApplicationExists(id))
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

        // POST: api/EndorsementApplications
        [HttpPost]
        public async Task<ActionResult<EndorsementApplication>> PostEndorsementApplication(EndorsementApplication endorsementApplication)
        {
            _context.EndorsementApplication.Add(endorsementApplication);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEndorsementApplication", new { id = endorsementApplication.EndorsAppID }, endorsementApplication);
        }

        // DELETE: api/EndorsementApplications/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EndorsementApplication>> DeleteEndorsementApplication(int id)
        {
            var endorsementApplication = await _context.EndorsementApplication.FindAsync(id);
            if (endorsementApplication == null)
            {
                return NotFound();
            }

            _context.EndorsementApplication.Remove(endorsementApplication);
            await _context.SaveChangesAsync();

            return endorsementApplication;
        }

        private bool EndorsementApplicationExists(int id)
        {
            return _context.EndorsementApplication.Any(e => e.EndorsAppID == id);
        }
    }
}
