// Modelo Alumno

using System.ComponentModel.DataAnnotations;

namespace NotasApp.Models
{
    public class Alumno
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este Campo es obligatorio")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Range(0,15)]
        public int Nota1 { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [Range(0,15)]
        public int Nota2 { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [Range(0,35)]
        public int Nota3 { get; set; }

        public float Promedio { get; set; }

        public void CalcularPromedio()
        {
           Promedio = (float)((Nota1 + Nota2 + Nota3) / 3);
           Promedio = (float)Math.Round(Promedio);
        }

    }
}