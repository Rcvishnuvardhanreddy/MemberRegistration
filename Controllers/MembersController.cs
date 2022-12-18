using MemberRegistration.DAL.Entities;
using MemberRegistration.DAL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MemberRegistration.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MembersController : ControllerBase
    {
        private IMemberService MemberService { get; set; }

        public MembersController(IMemberService memberService)
        {
            MemberService = memberService;
        }

        [HttpGet("all")]
        public List<MembersEntity> GetAllMembers()
        {
            return this.MemberService.GetAllMembers();
        }

        [HttpPost("")]
        public MembersEntity PostMember(MembersEntity newMember)
        {
            return this.MemberService.AddMember(newMember);
        }

        [HttpPut("{memberId}")]
        public MembersEntity PutMember(int memberId, MembersEntity newMember)
        {
            return this.MemberService.UpdateMember(newMember);
        }

        [HttpDelete("{memberId}")]
        public bool DeleteMember(int memberId)
        {
            return this.MemberService.DeleteMember(memberId);
        }
    }
}