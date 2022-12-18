using MemberRegistration.DAL.Entities;
using MemberRegistration.DAL.Interfaces;
using MemberRegistration.DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace MemberRegistration.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private IMangeUserService MangeUserService { get; set; }

        public UsersController(IMangeUserService mangeUserService)
        {
            this.MangeUserService = mangeUserService;
        }

        [HttpPost("signIn")]
        public async Task<UsersEntity> GetAllMembers(UserAuthModel userAuthModel)
        {
            return await this.MangeUserService.GetUser(userAuthModel.Email, userAuthModel.Password);
        }
    }
}