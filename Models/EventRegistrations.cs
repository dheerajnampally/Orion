namespace Orion.Models
{
    public class EventRegistrations
    {
        public int Id { get; set; }
        public ApplicationUser UserId { get; set; }
        public Tour EventId { get; set; }
    }
}
