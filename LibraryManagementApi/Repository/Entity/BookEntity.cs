using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementApi.Repository.Entity
{
    [Table("Book")]
    public class BookEntity : Entity
    {
        [Required]
        [StringLength(50)]
        public string Status { get; set; }

        [Required]
        [StringLength(20)]
        public string BorrowStatus { get; set; }

        [StringLength(50)]
        public string? Position { get; set; }


        [StringLength(36)]
        public string TitleBookId { get; set; }

        public virtual TitleEntity? Title { get; set; }
        public ICollection<DetailBorrowingBookEntity> DetailBorrowingBooks { get; set; }
    }
}
