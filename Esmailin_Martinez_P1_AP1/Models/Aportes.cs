using System.ComponentModel.DataAnnotations;

namespace Esmailin_Martinez_P1_AP1.Models
{
    public class Aportes
    {
        [Key]
        public int AporteId { get; set; }

        [Required(ErrorMessage = "El campo Persona no puede estar vacio.")]
        public string Persona { get; set; }

        [Required(ErrorMessage = "El campo Descripcion no puede estar vacio.")]
        [Range(01.1, double.MaxValue, ErrorMessage = "El monto debe ser mayor a 0.")]
        public double Monto { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;

        [Required(ErrorMessage ="Debe llenar este campo")]
        public string? Observaciones { get; set; }
    }
}
