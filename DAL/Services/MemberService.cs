using MemberRegistration.DAL.Entities;
using MemberRegistration.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MemberRegistration.DAL.Services
{
    public class MemberService : IMemberService
    {
        public ApplicationDBContext DbContext { get; }

        public DbSet<MembersEntity> Members { get; }

        public MemberService(ApplicationDBContext dbContext)
        {
            this.DbContext = dbContext;
            this.Members = dbContext.MembersEntity;
        }

        public MembersEntity AddMember(MembersEntity newMemberDetails)
        {
            this.Members.Add(newMemberDetails);
            this.DbContext.SaveChanges();
            return newMemberDetails;
        }

        public List<MembersEntity> GetAllMembers()
        {
            return this.Members.ToList();
        }

        public MembersEntity UpdateMember(MembersEntity newMemberDetails)
        {
            this.Members.Update(newMemberDetails);
            this.DbContext.SaveChanges();
            return newMemberDetails;
        }

        public bool DeleteMember(int memberId)
        {
            var selectedMember = this.Members.FirstOrDefault(m => m.Id == memberId);
            if (selectedMember != null)
            {
                this.Members.Remove(selectedMember);
                this.DbContext.SaveChanges();
                return true;
            }

            return false;
        }
    }
}
