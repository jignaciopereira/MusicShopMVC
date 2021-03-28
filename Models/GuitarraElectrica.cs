using System;
using System.ComponentModel.DataAnnotations;

namespace MusicShopMVC.Models
{
    public class GuitarraElectrica : InstrumentoCuerda
    {

        [Required(ErrorMessage = "Ingrese la cantidad de trastes")]
        [Display(Name = "Cantidad de trastes")]
        public int CantidadTrastes { get; set; }

        [Required(ErrorMessage = "Ingrese la cantidad de microfonos")]
        [Display(Name = "Cantidad de mics")]
        public int CAntidadMics { get; set; }
        
        [Required(ErrorMessage = "Ingrese el tipo de microfonos")]
        [Display(Name = "Tipo de microfonos")]
        [MaxLength(20)]
        public string TipoMics { get; set; }
        
        [Required(ErrorMessage = "Ingrese el tipo de madera")]
        [Display(Name = "Madera del mastil")]
        [MaxLength(20)]
        public string MaderaMastil { get; set; }

        [Required(ErrorMessage = "Ingrese el tipo de madera")]
        [Display(Name = "Madera del cuerpo")]
        [MaxLength(20)]
        public string MaderaCuerpo { get; set; }
        
        [Required(ErrorMessage = "Ingrese el tipo de puente")]
        [Display(Name = "Tipo de puente")]
        [MaxLength(20)]
        public string TipoPuente { get; set; }
    }
}
