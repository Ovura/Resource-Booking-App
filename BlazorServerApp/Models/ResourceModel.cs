namespace BlazorServerApp.Models
{
    public class ResourceModel
    {
        public int Id { get; set; }

        public int AvailableResourceId { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}