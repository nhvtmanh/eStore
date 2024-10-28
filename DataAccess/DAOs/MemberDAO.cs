using BusinessObject;
using eStoreAPI.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAOs
{
    public class MemberDAO
    {
        private readonly EStoreDbContext _dbContext;

        public MemberDAO(EStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Member> GetAllMembers()
        {
            return _dbContext.Members.ToList();
        }

        public Member GetMemberById(int memberId)
        {
            return _dbContext.Members.Find(memberId);
        }

        public void AddMember(MemberDTO memberDTO)
        {
            var member = new Member
            {
                Email = memberDTO.Email,
                CompanyName = memberDTO.CompanyName,
                City = memberDTO.City,
                Country = memberDTO.Country,
                Password = memberDTO.Password
            };

            _dbContext.Members.Add(member);
            _dbContext.SaveChanges();
        }

        public void UpdateMember(int id, MemberDTO memberDTO)
        {
            var member = _dbContext.Members.Find(id);

            member.Email = memberDTO.Email;
            member.CompanyName = memberDTO.CompanyName;
            member.City = memberDTO.City;
            member.Country = memberDTO.Country;
            member.Password = memberDTO.Password;

            _dbContext.SaveChanges();
        }

        public void DeleteMember(int memberId)
        {
            var member = _dbContext.Members.Find(memberId);
            if (member != null)
            {
                _dbContext.Members.Remove(member);
                _dbContext.SaveChanges();
            }
        }
    }
}
