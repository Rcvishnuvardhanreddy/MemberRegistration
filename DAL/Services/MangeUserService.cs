using MemberRegistration.DAL.Entities;
using MemberRegistration.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MemberRegistration.DAL.Services
{
    public class MangeUserService : IMangeUserService
    {
        public ApplicationDBContext DbContext { get; }

        public MangeUserService(ApplicationDBContext dbContext)
        {
            this.DbContext = dbContext;
        }

        public async Task<UsersEntity> GetUser(string email, string password)
        {
            var result = await this.DbContext.UsersEntity.AsNoTracking().FirstOrDefaultAsync(rec => rec.Email == email && rec.Password == password);
            return result;
        }
    }
}
