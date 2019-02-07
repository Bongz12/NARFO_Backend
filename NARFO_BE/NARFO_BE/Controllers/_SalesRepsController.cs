using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NARFO_BE.Models;

namespace NARFO_BE.Controllers
{
    [Route("salesReps")]
    public class _SalesRepsController : ControllerBase
    {
        private readonly narfoContext _context;
        private ActionResult<_SalesReps> Json(object p) { throw new NotImplementedException(); }

        public _SalesRepsController(narfoContext context) {
            _context = context;
            if (!_context.SalesReps.Any()) {
                _SalesReps newSalesReps = new _SalesReps();
                newSalesReps.Id = 1; newSalesReps.Username = "Mike"; newSalesReps.Firstname = "Mike"; newSalesReps.Username = "James"; newSalesReps.IDNo = "CN12345678"; newSalesReps.Physical_Address = "Diep in the berg" ;
                _context.SalesReps.AddAsync(newSalesReps);
                _context.SaveChanges();
            }
        }

        [HttpGet("get/all")]
        public async Task<ActionResult<IEnumerable<_SalesReps>>> GetallSales() { return await _context.SalesReps.ToListAsync(); }

        [HttpGet("get/{id}")]
        public async Task<ActionResult<_SalesReps>> GetSalesRep(int id)
        {
            var asales = await _context.SalesReps.FindAsync(id); //gets the member with matching id
            if (asales == null) { return BadRequest(new { status = "failed", error = "Failed to connect" }); }//fail response 
            return Ok(new { status = "success", members = asales });//success response
        }

        [HttpGet("get/all/sales")]
        public async Task<ActionResult<SalesRepsPrototype>> GetSales()
        {
            List<SalesRepsPrototype> salesRepslist = new List<SalesRepsPrototype>();

            foreach (_SalesReps _Sales in await _context.SalesReps.ToArrayAsync())
            {
                if (_Sales.Firstname != null && _Sales.SURNAME != null)
                    salesRepslist.Add(new SalesRepsPrototype(_Sales.Firstname, _Sales.SURNAME));
            }
            if (salesRepslist == null) { return BadRequest(new { status = "failed", error = "Failed to connect" }); }
            return Ok(new { status = "success", members = salesRepslist });
        }



    }
}
