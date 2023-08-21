using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagementApi.Repository.Entity
{
    public class PublisherEntity : Entity
    {
        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(200)]
        public string? Description { get; set; }

        [StringLength(200)]
        public string? Address { get; set; }

        [Required]
        [StringLength(200)]
        [EmailAddress]
        public string? Email { get; set; }

        public ICollection<TitleEntity> Titles { get; set; }
    }
}
