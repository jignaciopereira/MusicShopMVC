using System;
using System.ComponentModel.DataAnnotations;

namespace MusicShopMVC.Models
{
    public class Violin : InstrumentoCuerda
    {
        
        [Required(ErrorMessage = "Ingrese el tipo de violín")]
        [MaxLength(30)]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "Ingrese la digitación")]
        [MaxLength(30)]
        public string Digitacion { get; set; }
    }
}