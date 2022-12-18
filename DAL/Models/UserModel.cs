using System;

namespace MemberRegistration.DAL.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        
        public string UserName { get; set; }

        public string Email { get; set; }
        
        public string Password { get; set; }

        public bool IsAdmin { get; set; }
    }

    public class UserAuthModel
    {
        public string Email { get; set; }

        public string Password { get; set; }

    }
}
