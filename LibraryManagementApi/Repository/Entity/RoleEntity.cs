using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementApi.Repository.Entity
{
    [Table("Role")]
    public class RoleEntity : Entity
    {
        [StringLength(200)]
        public string? Description { get; set; }

        public ICollection<LibrarianEntity> Librarians { get; set; }
        public ICollection<LibraryCardEntity> LibraryCards { get; set; }
    }
}
