using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementApi.Repository.Entity
{
    [Table("Author")]
    public class AuthorEntity : Entity
    {
        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(200)]
        public string? Description { get; set; }

        public DateTimeOffset? Birthday { get; set; }

        public DateTimeOffset? DeathDate { get; set; }

        [StringLength(6)]
        public string? Gender { get; set; }

        public ICollection<BookAuthorEntity> BookAuthors { get; set; }
    }
}
