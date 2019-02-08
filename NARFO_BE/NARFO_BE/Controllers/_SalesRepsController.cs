using System;
using System.Collections.Generic;
//using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NARFO_BE.Models;
using Microsoft.AspNetCore.Cors;

namespace NARFO_BE.Controllers
{
    [Route("api/salesReps")]
    [EnableCors("MyPolicy")]
    public class SalesRepsController : ControllerBase
    {
        private readonly narfoContext _context;
        private ActionResult<SalesReps> Json(object p) { throw new NotImplementedException(); }

        public SalesRepsController(narfoContext context) {
            _context = context;
            if (!_context.SalesReps.Any()) {
                SalesReps newSalesReps = new SalesReps();
                _context.SalesReps.AddAsync(newSalesReps);
                _context.SaveChanges();
            }
        }

        [HttpGet("get/all")]
        public async Task<ActionResult<IEnumerable<SalesReps>>> GetallSales() { return await _context.SalesReps.ToListAsync(); }

        [HttpGet("get/{id}")]
        public async Task<ActionResult<SalesReps>> GetSalesRep(int id)
        {
            var asales = await _context.SalesReps.FindAsync(id); //gets the member with matching id
            if (asales == null) { return BadRequest(new { status = "failed", error = "Failed to connect" }); }//fail response 
            return Ok(new { status = "success", members = asales });//success response
        }

        [HttpGet("get/all/sales")]
        public async Task<ActionResult<SalesRepsPrototype>> GetSales()
        {
            List<SalesRepsPrototype> salesRepslist = new List<SalesRepsPrototype>();

            foreach (SalesReps _Sales in await _context.SalesReps.ToArrayAsync())
            {
                var member = await _context.Member.FindAsync(_Sales.MemNo);
                if (member.Firstname!= null && member.Surname != null)
                    salesRepslist.Add(new SalesRepsPrototype(member.Firstname, member.Surname));
            }
            if (salesRepslist == null) { return BadRequest(new { status = "failed", error = "Failed to connect" }); }
            return Ok(new { status = "success", members = salesRepslist });
        }



    }
}
