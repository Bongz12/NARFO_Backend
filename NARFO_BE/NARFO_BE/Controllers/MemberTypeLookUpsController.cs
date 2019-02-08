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
    public class MemberTypeLookUpsController : ControllerBase
    {
        private readonly narfoContext _context;

        public MemberTypeLookUpsController(narfoContext context)
        {
            _context = context;
        }

        // GET: api/MemberTypeLookUps
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MemberTypeLookUp>>> GetMemberTypeLookUp()
        {
            return await _context.MemberTypeLookUp.ToListAsync();
        }

        // GET: api/MemberTypeLookUps/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MemberTypeLookUp>> GetMemberTypeLookUp(int id)
        {
            var memberTypeLookUp = await _context.MemberTypeLookUp.FindAsync(id);

            if (memberTypeLookUp == null)
            {
                return NotFound();
            }

            return memberTypeLookUp;
        }

        // PUT: api/MemberTypeLookUps/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMemberTypeLookUp(int id, MemberTypeLookUp memberTypeLookUp)
        {
            if (id != memberTypeLookUp.MemberTypeId)
            {
                return BadRequest();
            }

            _context.Entry(memberTypeLookUp).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MemberTypeLookUpExists(id))
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

        // POST: api/MemberTypeLookUps
        [HttpPost]
        public async Task<ActionResult<MemberTypeLookUp>> PostMemberTypeLookUp(MemberTypeLookUp memberTypeLookUp)
        {
            _context.MemberTypeLookUp.Add(memberTypeLookUp);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (MemberTypeLookUpExists(memberTypeLookUp.MemberTypeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetMemberTypeLookUp", new { id = memberTypeLookUp.MemberTypeId }, memberTypeLookUp);
        }

        // DELETE: api/MemberTypeLookUps/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<MemberTypeLookUp>> DeleteMemberTypeLookUp(int id)
        {
            var memberTypeLookUp = await _context.MemberTypeLookUp.FindAsync(id);
            if (memberTypeLookUp == null)
            {
                return NotFound();
            }

            _context.MemberTypeLookUp.Remove(memberTypeLookUp);
            await _context.SaveChangesAsync();

            return memberTypeLookUp;
        }

        private bool MemberTypeLookUpExists(int id)
        {
            return _context.MemberTypeLookUp.Any(e => e.MemberTypeId == id);
        }
    }
}
