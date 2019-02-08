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
    public class BankDetailsController : ControllerBase
    {
        private readonly narfoContext _context;

        public BankDetailsController(narfoContext context)
        {
            _context = context;
        }

        // GET: api/BankDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BankDetails>>> GetBankDetails()
        {
            return await _context.BankDetails.ToListAsync();
        }

        // GET: api/BankDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BankDetails>> GetBankDetails(string id)
        {
            var bankDetails = await _context.BankDetails.FindAsync(id);

            if (bankDetails == null)
            {
                return NotFound();
            }

            return bankDetails;
        }

        // PUT: api/BankDetails/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBankDetails(string id, BankDetails bankDetails)
        {
            if (id != bankDetails.BankDetailsId)
            {
                return BadRequest();
            }

            _context.Entry(bankDetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BankDetailsExists(id))
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

        // POST: api/BankDetails
        [HttpPost]
        public async Task<ActionResult<BankDetails>> PostBankDetails(BankDetails bankDetails)
        {
            _context.BankDetails.Add(bankDetails);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (BankDetailsExists(bankDetails.BankDetailsId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetBankDetails", new { id = bankDetails.BankDetailsId }, bankDetails);
        }

        // DELETE: api/BankDetails/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<BankDetails>> DeleteBankDetails(string id)
        {
            var bankDetails = await _context.BankDetails.FindAsync(id);
            if (bankDetails == null)
            {
                return NotFound();
            }

            _context.BankDetails.Remove(bankDetails);
            await _context.SaveChangesAsync();

            return bankDetails;
        }

        private bool BankDetailsExists(string id)
        {
            return _context.BankDetails.Any(e => e.BankDetailsId == id);
        }
    }
}
