namespace LibraryManagementApi.Service.Model.RequestModel
{
    public class TitleRequest
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? PublishingYear { get; set; }
        public string? Image { get; set; }
        public int? Gages { get; set; }
        public string? Language { get; set; }
    }
}
