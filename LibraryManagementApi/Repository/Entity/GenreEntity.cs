using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementApi.Repository.Entity
{
    [Table("Genre")]
    public class GenreEntity : Entity
    {
        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public ICollection<BookGenreEntity> BookGenres { get; set; }
    }
}
