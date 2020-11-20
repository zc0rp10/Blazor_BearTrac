namespace BlazorBearTrac.Models
{
    public class Ticket
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Application { get; set; } //TODO: Change return type to Application
        public Type Type { get; set; }
        public Status Status { get; set; }
    }

    public enum Type
    {
        Bug,
        Request
    }

    public enum Status
    {
        New,
        InProgress,
        Completed,
    }
}