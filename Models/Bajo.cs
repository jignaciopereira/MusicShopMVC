using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicShopMVC.Models
{
    public class Bajo
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
        [Display(Name = "Orientacion de la mano")]
        [MaxLength(10)]
        public string OrientacionMano { get; set; }
        
        [Required(ErrorMessage = "Campo obligatorio")]
        [Display(Name = "Cantidad de cuerdas")]
        public int CantidadCuerdas { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Display(Name = "Cantidad de trastes")]
        public int CantidadTrastes { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Display(Name = "Cantidad de mics")]
        public int CAntidadMics { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Display(Name = "Cantidad de controles")]
        [MaxLength(20)]
        public string CantidadControles { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(20)]
        public string Origen { get; set; }
        
        [Required(ErrorMessage = "Campo obligatorio")]
        [Display(Name = "Madera del mastil")]
        [MaxLength(20)]
        public string MaderaMastil { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Display(Name = "Madera del cuerpo")]
        [MaxLength(20)]
        public string MaderaCuerpo { get; set; }
    }
}