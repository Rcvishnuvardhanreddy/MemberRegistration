using MemberRegistration.DAL.Entities;

namespace MemberRegistration.DAL.Interfaces
{
    public interface IMemberService
    {
        MembersEntity AddMember(MembersEntity newMemberDetails);
        
        MembersEntity UpdateMember(MembersEntity newMemberDetails);
        
        bool DeleteMember(int memberId);
        
        List<MembersEntity> GetAllMembers();
    }
}
