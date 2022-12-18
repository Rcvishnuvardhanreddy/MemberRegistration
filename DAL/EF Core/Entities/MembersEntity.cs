using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MemberRegistration.DAL.Entities
{
    [Table("Members")]
    public class MembersEntity
    {
        public MembersEntity()
        {
            this.DateCreated = DateTime.UtcNow;
        }

        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }

        public string Address { get; set; }

        public DateTime DateCreated { get; set; }
    }
}
