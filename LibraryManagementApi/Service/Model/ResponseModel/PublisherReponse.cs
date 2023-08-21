namespace LibraryManagementApi.Service.Model.ResponseModel
{
    public class PublisherReponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public List<TitleResponse> Titles { get; set; }
    }
}
