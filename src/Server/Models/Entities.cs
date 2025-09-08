namespace Server.Models
{
    public class ModelSnapshot
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string SessionId { get; set; } = "";
        public DateTime CreateUtc { get; set; } = DateTime.UtcNow;
        public string Source { get; set; } = "Revit";
        public string Json { get; set; } = "";
    }

    public class ContextEvent
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string SessionId { get; set; } = "";
        public DateTime CreateUtc { get; set; } = DateTime.UtcNow;
        public string Kind { get; set; } = "";
        public string Payload { get; set; } = "";
    }
}