namespace Orion.Models
{
    public class EventRegistrations
    {
        public int Id { get; set; }
        public ApplicationUser User { get; set; }
        public Tours Tour { get; set; }
    }
}
