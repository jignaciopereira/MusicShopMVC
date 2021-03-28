using System;
using System.ComponentModel.DataAnnotations;

namespace MusicShopMVC.Models
{
    public class Bateria : InstrumentoPercusion
    {
        [Required(ErrorMessage = "Ingrese la línea")]
        [MaxLength(30)]
        public string Linea { get; private set; }

        [Required(ErrorMessage = "Ingrese la cantidad de cuerpos")]
        [Display(Name = "Cantidad de cuerpos")]
        public string Cuerpo { get; set; }

        [Required(ErrorMessage = "Ingrese la cantidad de platillos")]
        [Display(Name = "Cantidad de platillos")]
        public string Platillos { get; set; }

        public bool PedalBombo { get; set; }

        public bool Banqueta { get; set; }
    }
}