using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementApi.Repository.Entity
{
    [Table("Title")]
    public class TitleEntity : Entity
    {
        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public int? PublishingYear { get; set; }

        [StringLength(200)]
        public string? Image { get; set; }

        public int? Gages { get; set; }

        [StringLength(50)]
        public string? Language { get; set; }

        [StringLength(10)]
        public string? PublisherId { get; set; }
        public virtual PublisherEntity Publisher { get; set; }
    }
}
