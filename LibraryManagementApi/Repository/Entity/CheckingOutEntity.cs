using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementApi.Repository.Entity
{
    [Table("CheckingOut")]
    public class CheckingOutEntity : Entity
    {
        [StringLength(10)]
        public string LibraryCardId { get; set; }

        [StringLength(10)]
        public string LibrarianId { get; set; }

        public DateTimeOffset? BorrowingDate { get; set; }

        [StringLength(10)]
        public string InvoiceId { get; set; }

        public ICollection<DetailBorrowingBookEntity> DetailBorrowingBooks { get; set; }
        public virtual InvoiceEntity Invoice { get; set; }
        public virtual LibraryCardEntity LibraryCard { get; set; }
        public virtual LibrarianEntity Librarian { get; set; }

    }
}
