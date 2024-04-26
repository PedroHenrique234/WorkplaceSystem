namespace WorkplaceSystem.Models
{
    public class ClientModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime CreateDate { get; set; }
        public List<UseModel>? ClientUses { get; set; }
    }
}
