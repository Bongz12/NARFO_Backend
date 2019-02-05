using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using NARFO_API;

namespace NARFO_API.Controllers
{
   
    
    
    [Route("Member")]
    public class MemberController : ControllerBase
    {
        private readonly narfoContext _db;
        

        [HttpGet("get/all")]
        public async Task<ActionResult<IEnumerable<Members>>> GetMembersAsync()
        {
            return await _db.Members.ToListAsync();
        }

        [HttpGet("get/{id}")]
        public async Task<ActionResult<Members>> GetMembersAsync(int id)
        {
            return await _db.Members.FindAsync(id);
        }

        [HttpPost("set")]
        public async Task<ActionResult<Members>> SetMember(Members newMember)
        {
           /* newMember.Password = Encript.Encrypt_user(newMember.Password);
            await _db.Members.AddAsync(newMember);
            await _db.SaveChangesAsync();*/
            return null;
        }

        [HttpPost("login")]
        public async Task<ActionResult<Members>> LoginMember(Members newMember)
        {
            // newMember.Password = Encript.Encrypt_user(newMember.Password);
            /*
            Members member = _db.Members.Find(newMember.Username);

            if (member.Password == newMember.Password)
                return member;
            */
            return null;
        }


    }
}