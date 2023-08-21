using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementApi.Repository.Entity
{
    [Table("Invoice")]
    public class InvoiceEntity : Entity
    {
        [StringLength(200)]
        public string Name { get; set; }

        public DateTimeOffset? InvoiceDate { get; set; }

        [StringLength(200)]
        public string? Description { get; set; }

        public decimal TotalAmount { get; set; }

        [StringLength(20)]
        public string PaymentStatus { get; set; }

        public ICollection<CheckingOutEntity> Borrowings { get; set; }
    }
}
