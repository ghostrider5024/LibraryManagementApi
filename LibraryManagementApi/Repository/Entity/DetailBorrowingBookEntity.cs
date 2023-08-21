using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementApi.Repository.Entity
{
    [Table("DetailBorrowingBook")]
    public class DetailBorrowingBookEntity : EntityWithoutKey
    {
        [StringLength(10)]
        public string BorrowingId { get; set; }

        [StringLength(10)]
        public string BookId { get; set; }

        public DateTimeOffset? ReturnDate { get; set; }

        [StringLength(50)]
        public string BorrowStatus { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public virtual CheckingOutEntity? Borrowing { get; set; }
        public virtual BookEntity? Book { get; set; }
    }
}
