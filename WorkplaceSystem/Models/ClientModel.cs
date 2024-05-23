using System.ComponentModel.DataAnnotations;

namespace WorkplaceSystem.Models
{
    public class ClientModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o nome do cliente!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Digite o telefone do cliente!")]
        public string PhoneNumber { get; set; } 
        [Required(ErrorMessage = "Digite o CPF do cliente!")]
        public string CPF { get; set; } 
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public List<UseModel>? ClientUses { get; set; }
        public bool Situation { get; set; } = true;
        public TimeSpan TotalTime { get; set; }
    }
}
