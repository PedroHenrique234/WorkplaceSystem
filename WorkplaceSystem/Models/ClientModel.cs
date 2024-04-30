namespace WorkplaceSystem.Models
{
    public class ClientModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? PhoneNumber { get; set; }
        public string CPF { get; set; } 
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public List<UseModel>? ClientUses { get; set; }
        public bool Situation { get; set; } = true;

    }
}
