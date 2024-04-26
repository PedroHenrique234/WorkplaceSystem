namespace WorkplaceSystem.Models
{
    public class UseModel
    {
        public int useId { get; set; }
        public DateTime DateUse { get; set; }
        public TimeSpan StartUse { get; set; }
        public TimeSpan EndUse { get; set; }
        public TimeSpan TotalUse { get; set; }
        public int ClientId { get; set; }
        public ClientModel Client { get; set; }
    }
}
