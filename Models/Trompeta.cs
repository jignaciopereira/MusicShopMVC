using System;
using System.ComponentModel.DataAnnotations;

namespace MusicShopMVC.Models
{
    public class Trompeta : InstrumentoViento
    {   
        [Required(ErrorMessage = "Ingrese la afinación")]
        [MaxLength(30)]
        public string Afinacion { get; set; }
    }
}