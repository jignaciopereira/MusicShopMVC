using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace MusicShopMVC.Models
{
    public class InstrumentoTecla : ClaseBase
    {
        public int MarcaID { get; set; }
        public Marca Marca { get; set; }

        [Required(ErrorMessage = "Ingrese el modelo")]
        [MaxLength(30)]
        public string Modelo { get; set; }
        
        [Required(ErrorMessage = "Ingrese la cantidad de teclas")]
        [Display(Name = "Cantidad de teclas")]
        public int CantidadTeclas { get; set; }

        [Display(Name = "Imagen")]
        public string NombreImagen { get; set; }
        
        [NotMapped]
        public IFormFile ImagenSubir { get; set; }  
    }
}