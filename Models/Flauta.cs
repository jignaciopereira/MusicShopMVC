using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicShopMVC.Models
{
    public class Flauta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(30)]
        public string Marca { get; set; }
        
        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(30)]
        public string Modelo { get; set; }
        
        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(30)]
        public string Tipo { get; set; }
        
        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(30)]
        public string Material { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(30)]
        public string Digitacion { get; set; }
    }
}