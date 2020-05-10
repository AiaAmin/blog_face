namespace Dal.models
{
    public class SightedService
    {
        public int Id { get; set; }
        public int SightedId { get; set; }
        public Sighted Sighted { get; set; }
        public int ServiceId { get; set; }
        public Service Service { get; set; }
    }
}