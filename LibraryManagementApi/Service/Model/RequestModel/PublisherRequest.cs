using System.ComponentModel.DataAnnotations;

namespace LibraryManagementApi.Service.Model.RequestModel
{
    public class PublisherRequest
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
    }
}
