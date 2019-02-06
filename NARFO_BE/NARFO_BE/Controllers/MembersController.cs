using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
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
        public UserManager<_Member> UserManager { get; private set; }

        public MembersController(narfoContext context)
        {
            _context = context;
            if (!_context.Members.Any())
            {
                _Member newMember = new _Member();
                newMember.SURNAME = "admin";
                newMember.Username = "admin";
                newMember.Firstname = "admin";
                newMember.Email = "admin@admin.com";
               
                _context.Members.AddAsync(newMember);
                _context.SaveChanges();
            }
        }

        public void ListofMembers(List<_Member> members)
        {
            this.members = members;
        }

        //
        // POST: /Account/Login
        [HttpPost("get/login")]
        public async Task<ActionResult <_Member>> Login([FromBody] _Member model)
        {
            
            _Member user = await _context.Members.FirstOrDefaultAsync(member=>member.Email == model.Email && member.Password == encryption.ComputeHash(model.Password));

            if (user == null)
            {
                return BadRequest(new { status = "Failed", message = "Invalid login" });
            }
            else {

                return Ok(new { status = "Success", member = model });
            }
            
            
        }

        private ActionResult<_Member> Json(object p)
        {
            throw new NotImplementedException();
        }


        // GET: Member/Email
        [HttpGet("get/all/user")]
        public  async Task<ActionResult<MemberPrototype>> GetMembersEmail()
        {
           
           List<MemberPrototype> endpoint = new List<MemberPrototype>();
            foreach (_Member d in  await _context.Members.ToArrayAsync())
            {
                if(d.Username !=  null && d.Email != null )
            endpoint.Add(new MemberPrototype(d.Username,d.Email));       
            }
            if(endpoint == null)
            {
                return BadRequest(new { status = "failed", error = "Failed to connect" });
            }
          return      Ok(new { status = "success", members=endpoint });
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
            var amembers = await _context.Members.FindAsync(id);

            if (amembers == null)
            {
                return BadRequest(new { status = "failed", error = "Failed to connect" });
            }
            return Ok(new { status = "success", members = amembers });
        }

     
       [HttpPost("set")]
       public async Task<ActionResult<_Member>> setMember([FromBody]_Member member)
        {
            member.Password = encryption.ComputeHash(member.Password);
            await _context.Members.AddAsync(member);
            await _context.SaveChangesAsync();

            if (members == null)
            {
                return BadRequest(new { status = "failed", error = "Failed to connect" });
            }
            return Ok(new { status = "success", member = members });
        }




        private bool MembersExists(int id)
        {
            return _context.Members.Any(e => e.Id == id);
        }
    }
}
