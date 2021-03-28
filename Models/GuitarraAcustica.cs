using System;
using System.ComponentModel.DataAnnotations;

namespace MusicShopMVC.Models
{
    public class GuitarraAcustica : InstrumentoCuerda
    {
        [Required(ErrorMessage = "Ingrese la cantidad de trastes")]
        [Display(Name = "Cantidad de trastes")]
        public int CantidadTrastes { get; set; }

        [Required(ErrorMessage = "Ingrese el tipo de madera")]
        [Display(Name = "Madera del cuerpo")]
        [MaxLength(20)]
        public string MaderaCuerpo { get; set; }
        
        [Required(ErrorMessage = "Ingrese el tipo")]
        public bool ElectroAcustica { get; set; }  
    }
}
