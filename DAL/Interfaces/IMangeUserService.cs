using MemberRegistration.DAL.Entities;

namespace MemberRegistration.DAL.Interfaces
{
    public interface IMangeUserService
    {
        Task<UsersEntity> GetUser(string email, string password);
    }
}
