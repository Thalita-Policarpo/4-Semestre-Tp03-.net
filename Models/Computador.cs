using System.ComponentModel.DataAnnotations;

namespace Tp03_.netApp.Models
{
    public class Computador
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Marca { get; set; }

        [Required]
        public string Processador { get; set; }

        [Required]
        public string PlacaMae { get; set; }

        [Required]
        public string Memoria { get; set; }

        [Required]
        public string HD { get; set; }

        [Required]
        public string NumeroPatrimonio { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DataCompra { get; set; }

        
    }
}
