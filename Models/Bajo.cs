using System;
using System.ComponentModel.DataAnnotations;

namespace MusicShopMVC.Models
{
    public class Bajo : InstrumentoCuerda
    {
        [Required(ErrorMessage = "Ingrese la cantidad de trastes")]
        [Display(Name = "Cantidad de trastes")]
        public int CantidadTrastes { get; set; }

        [Required(ErrorMessage = "Ingrese la cantidad de microfonos")]
        [Display(Name = "Cantidad de mics")]
        public int CAntidadMics { get; set; }
        
        [Required(ErrorMessage = "Ingrese el tipo de madera")]
        [Display(Name = "Madera del mastil")]
        [MaxLength(20)]
        public string MaderaMastil { get; set; }

        [Required(ErrorMessage = "Ingrese el tipo de madera")]
        [Display(Name = "Madera del cuerpo")]
        [MaxLength(20)]
        public string MaderaCuerpo { get; set; }
    }
}