using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementApi.Repository.Entity
{
    [Table("BookGenre")]
    public class BookGenreEntity : EntityWithoutKey
    {
        [StringLength(36)]
        public string TitleBookId { get; set; }
       
        [StringLength(36)]
        public string GenreId { get; set; }

        public virtual TitleEntity? Title { get; set; }
        public virtual GenreEntity? Genre { get; set; }
    }
}
