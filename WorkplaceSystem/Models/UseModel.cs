using System.ComponentModel.DataAnnotations;
using WorkplaceSystem.Enums;

namespace WorkplaceSystem.Models
{
    public class UseModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite a data de uso")]
        public DateTime DateUse { get; set; }
        [Required(ErrorMessage = "Digite o horário de início")]
        public TimeSpan StartUse { get; set; }
        [Required(ErrorMessage = "Digite o horário de término")]
        public TimeSpan EndUse { get; set; }
        public TimeSpan TotalUse { get; set; }
        public int ClientId { get; set; }
        public ClientModel Client { get; set; }
        public RoomsEnum RentedRoom { get; set; }
    }
}
