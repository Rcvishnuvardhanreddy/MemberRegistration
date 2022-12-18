using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MemberRegistration.DAL.Entities
{
    [Table("Users")]
    public class UsersEntity
    {
        [Key]
        [Required]
        public int Id { get; set; }

        public string UserName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public bool IsAdmin { get; set; }
    }
}
