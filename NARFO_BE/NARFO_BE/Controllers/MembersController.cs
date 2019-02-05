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
    [Route("Member")]
    [EnableCors("MyPolicy")]
    public class MembersController : ControllerBase
    {
        private readonly narfoContext _context;
        List<_Member> members = new List<_Member>();

        public MembersController(narfoContext context)
        {
            _context = context;
            if (!_context.Members.Any())
            {
                _Member newMember = new _Member();
                newMember.SURNAME = "admin";
                newMember.Username = "admin";
                newMember.Firstname = "admin";
               
                _context.Members.AddAsync(newMember);
                _context.SaveChanges();
            }
        }

        public void ListofMembers(List<_Member> members)
        {
            this.members = members;
        }


        // GET: api/Members
        [HttpGet("get/all")]
        public async Task<ActionResult<IEnumerable<_Member>>> GetMembers()
        {
            return await _context.Members.ToListAsync();
        }
        public IEnumerable<_Member> GetAllMembers()
        {
            return members;
        }

        // GET: api/Members/5
        [HttpGet("get/{id}")]
        public async Task<ActionResult<_Member>> GetMembers(int id)
        {
            var members = await _context.Members.FindAsync(id);

            if (members == null)
            {
                return NotFound();
            }

            return members;
        }

        [HttpGet("get/shai")]
        public string  getShai()
        {
            return encryption.ComputeHash("12345");
        }

       [HttpPost("set")]
       public async Task<ActionResult<_Member>> setMember([FromBody]_Member member)
        {
            await _context.Members.AddAsync(member);
            await _context.SaveChangesAsync();
            return member;
        }




        private bool MembersExists(int id)
        {
            return _context.Members.Any(e => e.Id == id);
        }
    }
}
