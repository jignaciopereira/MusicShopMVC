using System;
using System.ComponentModel.DataAnnotations;

namespace MusicShopMVC.Models
{
    public class Flauta : InstrumentoViento
    {
        [Required(ErrorMessage = "Ingrese la digitación")]
        [MaxLength(30)]
        public string Digitacion { get; set; }
    }
}