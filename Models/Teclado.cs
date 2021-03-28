using System;
using System.ComponentModel.DataAnnotations;

namespace MusicShopMVC.Models
{
    public class Teclado : InstrumentoTecla
    { 
        [Required(ErrorMessage = "Ingrese la cantidad de ritmos")]
        [Display(Name = "Cantidad de ritmos")]
        public int CantidadRitmos { get; set; }
    }
}