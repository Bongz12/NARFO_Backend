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
    public class PendingRenewalsController : ControllerBase
    {
        private readonly narfoContext _context;

        public PendingRenewalsController(narfoContext context)
        {
            _context = context;
        }

        // GET: api/PendingRenewals
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PendingRenewal>>> GetPendingRenewal()
        {
            return await _context.PendingRenewal.ToListAsync();
        }

        // GET: api/PendingRenewals/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PendingRenewal>> GetPendingRenewal(int id)
        {
            var pendingRenewal = await _context.PendingRenewal.FindAsync(id);

            if (pendingRenewal == null)
            {
                return NotFound();
            }

            return pendingRenewal;
        }

        // PUT: api/PendingRenewals/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPendingRenewal(int id, PendingRenewal pendingRenewal)
        {
            if (id != pendingRenewal.RenewalD)
            {
                return BadRequest();
            }

            _context.Entry(pendingRenewal).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PendingRenewalExists(id))
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

        // POST: api/PendingRenewals
        [HttpPost]
        public async Task<ActionResult<PendingRenewal>> PostPendingRenewal(PendingRenewal pendingRenewal)
        {
            _context.PendingRenewal.Add(pendingRenewal);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PendingRenewalExists(pendingRenewal.RenewalD))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPendingRenewal", new { id = pendingRenewal.RenewalD }, pendingRenewal);
        }

        // DELETE: api/PendingRenewals/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PendingRenewal>> DeletePendingRenewal(int id)
        {
            var pendingRenewal = await _context.PendingRenewal.FindAsync(id);
            if (pendingRenewal == null)
            {
                return NotFound();
            }

            _context.PendingRenewal.Remove(pendingRenewal);
            await _context.SaveChangesAsync();

            return pendingRenewal;
        }

        private bool PendingRenewalExists(int id)
        {
            return _context.PendingRenewal.Any(e => e.RenewalD == id);
        }
    }
}
