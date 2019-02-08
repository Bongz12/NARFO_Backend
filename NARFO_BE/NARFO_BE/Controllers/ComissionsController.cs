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
    public class ComissionsController : ControllerBase
    {
        private readonly narfoContext _context;

        public ComissionsController(narfoContext context)
        {
            _context = context;
        }

        // GET: api/Comissions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Comission>>> GetComission()
        {
            return await _context.Comission.ToListAsync();
        }

        // GET: api/Comissions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Comission>> GetComission(short id)
        {
            var comission = await _context.Comission.FindAsync(id);

            if (comission == null)
            {
                return NotFound();
            }

            return comission;
        }

        // PUT: api/Comissions/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutComission(short id, Comission comission)
        {
            if (id != comission.ComissionId)
            {
                return BadRequest();
            }

            _context.Entry(comission).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ComissionExists(id))
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

        // POST: api/Comissions
        [HttpPost]
        public async Task<ActionResult<Comission>> PostComission(Comission comission)
        {
            _context.Comission.Add(comission);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ComissionExists(comission.ComissionId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetComission", new { id = comission.ComissionId }, comission);
        }

        // DELETE: api/Comissions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Comission>> DeleteComission(short id)
        {
            var comission = await _context.Comission.FindAsync(id);
            if (comission == null)
            {
                return NotFound();
            }

            _context.Comission.Remove(comission);
            await _context.SaveChangesAsync();

            return comission;
        }

        private bool ComissionExists(short id)
        {
            return _context.Comission.Any(e => e.ComissionId == id);
        }
    }
}
