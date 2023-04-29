using System.ComponentModel.DataAnnotations;

namespace StadiumTickets.Shared.Entities
{
    public class Ticket
    {
        public int Id { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}")]
        [Display(Name = "Fecha/Hora")]
        public DateTime? UseDate { get; set; }
        public bool Used { get; set; }
        [Display(Name = "Porteria")]
        [MaxLength(20, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        public string? Entrance { get; set; }
    }
}
