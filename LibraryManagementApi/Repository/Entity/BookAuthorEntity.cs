using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementApi.Repository.Entity
{
    [Table("BookAuthor")]
    public class BookAuthorEntity : EntityWithoutKey
    {
        [StringLength(36)]
        public string TitleBookId { get; set; }

        [StringLength(36)]
        public string AuthorId { get; set; }

        [StringLength(20)]
        public string Role { get; set; }

        public virtual TitleEntity? Title { get; set; }
        public virtual AuthorEntity? Author { get; set; }
    }
}
