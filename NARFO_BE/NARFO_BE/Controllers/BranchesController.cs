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
    public class BranchesController : ControllerBase
    {
        private readonly narfoContext _context;

        public BranchesController(narfoContext context)
        {
            _context = context;
        }

        // GET: api/Branches
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Branch>>> GetBranch()
        {
            return await _context.Branch.ToListAsync();
        }

        // GET: api/Branches/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Branch>> GetBranch(string id)
        {
            var branch = await _context.Branch.FindAsync(id);

            if (branch == null)
            {
                return NotFound();
            }

            return branch;
        }

        // PUT: api/Branches/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBranch(string id, Branch branch)
        {
            if (id != branch.Branch1)
            {
                return BadRequest();
            }

            _context.Entry(branch).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BranchExists(id))
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

        // POST: api/Branches
        [HttpPost]
        public async Task<ActionResult<Branch>> PostBranch(Branch branch)
        {
            _context.Branch.Add(branch);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (BranchExists(branch.Branch1))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetBranch", new { id = branch.Branch1 }, branch);
        }

        // DELETE: api/Branches/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Branch>> DeleteBranch(string id)
        {
            var branch = await _context.Branch.FindAsync(id);
            if (branch == null)
            {
                return NotFound();
            }

            _context.Branch.Remove(branch);
            await _context.SaveChangesAsync();

            return branch;
        }

        private bool BranchExists(string id)
        {
            return _context.Branch.Any(e => e.Branch1 == id);
        }
    }
}
