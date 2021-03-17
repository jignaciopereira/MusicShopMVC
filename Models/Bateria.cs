using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicShopMVC.Models
{
    public class Bateria
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

         [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(30)]
        public string Marca { get; private set; }
        
         [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(30)]
        public string Linea { get; private set; }

         [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(30)]
        public string Modelo { get; private set; }

        public string Cuerpo { get; set; }

        public string Platillos { get; set; }

        public string PedalBombo { get; set; }

        public string Banqueta { get; set; }
        
        public string DiametroBombo { get; set; }
    }
}