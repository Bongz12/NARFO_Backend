using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NARFO_BE.Models;

//RetroDavis>>
namespace NARFO_BE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DedicatedStatusController : ControllerBase
    {
        private readonly narfoContext _context;

        public DedicatedStatusController(narfoContext context)
        {
            _context = context;
        }

        // GET: api/DedicatedStatus
        [HttpGet("all" )]
        public async Task<ActionResult<IEnumerable<DedicatedStatus>>> GetDedicatedStatus()
        {
            return await _context.DedicatedStatus.ToListAsync();
        }

        // GET: api/DedicatedStatus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DedicatedStatus>> GetDedicatedStatus(int id)
        {
            var dedicatedStatus = await _context.DedicatedStatus.FindAsync(id);

            if (dedicatedStatus == null)
            {
                return NotFound();
            }

            return dedicatedStatus;
        }

        [HttpPost("approve")]
        public async Task<ActionResult>  PostApprove([FromBody]DedicatedStatus Dedicated )
        {
            var DedicatedS = await _context.DedicatedStatus.FirstOrDefaultAsync(Dedicate => Dedicate.Dsno == Dedicated.Dsno);
            if (DedicatedS == null)
            return BadRequest(new { Status = "failed", message = "Dedicated status not found" });
            DedicatedS.Approved = "Yes";
            _context.Entry(DedicatedS).State = EntityState.Modified;
           try
            {
           await     _context.SaveChangesAsync();
            }catch(DbUpdateException)
            {
                return BadRequest(new { Status = "failed", message = "Unable to communicate to database" });
            }
           return Ok(new { Status = "success", message = "Succesfully approved dedicated status" });
        }

        [HttpGet("filter/{Approve}")]
        public async Task<ActionResult> GetFilter(string Approve)
        {
           var DedicatedStatuses = from Dedicateditem in _context.DedicatedStatus where Dedicateditem.Approved == Approve select Dedicateditem;
            if(DedicatedStatuses.Any())
            {
                var DedicatedList = await DedicatedStatuses.ToListAsync();
                return Ok(new { Status = "success", dedicated = DedicatedList });
            }
            else
            {
                return BadRequest(new { Status = "failed", message = "No Dedicated statuses with status {"+Approve+"}" });
            }
        }
        // POST: api/DedicatedStatus
        [HttpPost("post/set")]
        public async Task<ActionResult<DedicatedStatus>> PostDedicatedStatus([FromBody]DedicatedStatus dedicatedStatus)
        {

            if(dedicatedStatus == null)
            {
                return BadRequest(new { Status = "failed", message = "Dedicated Status sent is null" });
            }
            dedicatedStatus.Approved = "No";
            dedicatedStatus.ApplicationDate = DateTime.Now;
            await _context.DedicatedStatus.AddAsync(dedicatedStatus);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                if (DedicatedStatusExists(dedicatedStatus.DedicatedId))
                {
                    return BadRequest(new { status = "failed", message = "Dedicated status already captured" });
                }
                else
                {
                    return BadRequest(new { status = "failed", message = "Failed to communicate to database",code=ex.StackTrace});
                }
            }

            return Ok(new { status = "success", message = "Dedicated status captured" });
        }

        private bool DedicatedStatusExists(int id)
        {
            return _context.DedicatedStatus.Any(e => e.DedicatedId == id);
        }
    }
}