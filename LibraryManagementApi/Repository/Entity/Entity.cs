using System.ComponentModel.DataAnnotations;

namespace LibraryManagementApi.Repository.Entity
{
    public class Entity : EntityWithoutKey
    {
        [Key]
        public string Id { get; set; }
    }

    public class EntityWithoutKey
    {
        public DateTimeOffset? DeleteDate { get; set; }
    }
}
