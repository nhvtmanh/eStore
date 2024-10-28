using BusinessObject;
using DataAccess.DAOs;
using DataAccess.Repositories.Interfaces;
using eStoreAPI.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Implementations
{
    public class MemberRepository : IMemberRepository
    {
        private readonly MemberDAO _memberDAO;

        public MemberRepository(EStoreDbContext context)
        {
            _memberDAO = new MemberDAO(context);
        }

        public IEnumerable<Member> GetAllMembers() => _memberDAO.GetAllMembers();

        public Member GetMemberById(int memberId) => _memberDAO.GetMemberById(memberId);

        public void AddMember(MemberDTO memberDTO) => _memberDAO.AddMember(memberDTO);

        public void UpdateMember(int id, MemberDTO memberDTO) => _memberDAO.UpdateMember(id, memberDTO);

        public void DeleteMember(int memberId) => _memberDAO.DeleteMember(memberId);
    }
}
