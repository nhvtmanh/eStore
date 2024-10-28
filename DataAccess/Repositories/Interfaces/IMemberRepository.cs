using BusinessObject;
using eStoreAPI.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Interfaces
{
    public interface IMemberRepository
    {
        IEnumerable<Member> GetAllMembers();
        Member GetMemberById(int memberId);
        void AddMember(MemberDTO memberDTO);
        void UpdateMember(int id, MemberDTO memberDTO);
        void DeleteMember(int memberId);
    }
}
