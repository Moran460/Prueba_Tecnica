using System;
using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class Loan
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Cliente { get; set; }
        [Required]
        public string Monto { get; set;}
        [Required]
        public string TasaIntereses { get; set;}
        [Required]
        public string PlazoMeses { get; set;}

        public DateTime FechaInicio { get; set;} = DateTime.Now;
        public object Tasa_Interes { get; internal set; }
    }
}
