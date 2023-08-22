using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementApi.Repository.Entity
{
    [Table("LibraryCard")]
    public class LibraryCardEntity : Entity
    {
        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(200)]
        public string? Description { get; set; }

        [Required]
        [StringLength(200)]
        public string Password { get; set; }

        [StringLength(6)]
        public string? Gender { get; set; }

        [StringLength(200)]
        public string? Address { get; set; }

        [StringLength(11)]
        public string? Phone { get; set; }

        [Required]
        [StringLength(200)]
        [EmailAddress]
        public string Email { get; set; }

        [StringLength(200)]
        public string? Image { get; set; }

        public DateTimeOffset? RegistrationDate { get; set; }

        public DateTimeOffset? ExpirationDate { get; set; }

        [StringLength(36)]
        public string RoleId { get; set; }

        public virtual RoleEntity? Role { get; set; }
        public ICollection<CheckingOutEntity> Borrowings { get; set; }
    }
}
