using System.ComponentModel.DataAnnotations;
using WorkplaceSystem.Enums;

namespace WorkplaceSystem.Models
{
    public class UseModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Insira a data de uso")]
        public DateTime DateUse { get; set; }
        [Required(ErrorMessage = "Insira o início de uso")]
        public TimeSpan StartUse { get; set; }
        [Required(ErrorMessage = "Insira o término de uso")]
        public TimeSpan EndUse { get; set; }
        public TimeSpan TotalUse { get; set; }
        public int ClientId { get; set; }
        public ClientModel Client { get; set; }
        [Required(ErrorMessage = "selecione a sala alugada")]
        public RoomsEnum RentedRoom { get; set; }
    }
}
