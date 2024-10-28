using BusinessObject;
using DataAccess.Repositories.Interfaces;
using eStoreAPI.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberAPI : ControllerBase
    {
        private readonly IMemberRepository _memberRepository;

        public MemberAPI(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }

        // GET: api/Member
        [HttpGet]
        public IActionResult GetAllMembers()
        {
            var members = _memberRepository.GetAllMembers();
            return Ok(members);
        }

        // GET: api/Member/5
        [HttpGet("{id}")]
        public IActionResult GetMemberById(int id)
        {
            var member = _memberRepository.GetMemberById(id);
            if (member == null)
            {
                return NotFound();
            }
            return Ok(member);
        }

        // POST: api/Member
        [HttpPost]
        public IActionResult CreateMember([FromBody] MemberDTO memberDTO)
        {
            if (ModelState.IsValid)
            {
                _memberRepository.AddMember(memberDTO);
                return Ok(memberDTO);
            }
            return BadRequest(ModelState);
        }

        // PUT: api/Member/5
        [HttpPut("{id}")]
        public IActionResult UpdateMember(int id, [FromBody] MemberDTO memberDTO)
        {
            var member = _memberRepository.GetMemberById(id);
            if (member == null)
            {
                return NotFound();
            }

            _memberRepository.UpdateMember(id, memberDTO);
            return NoContent();
        }

        // DELETE: api/Member/5
        [HttpDelete("{id}")]
        public IActionResult DeleteMember(int id)
        {
            _memberRepository.DeleteMember(id);
            return NoContent();
        }
    }
}
