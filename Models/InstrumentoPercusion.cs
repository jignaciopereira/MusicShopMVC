using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace MusicShopMVC.Models
{
    public class InstrumentoPercusion : ClaseBase
    {
        public int MarcaID { get; set; }
        public Marca Marca { get; set; }

        [Required(ErrorMessage = "Ingrese el modelo")]
        [MaxLength(30)]
        public string Modelo { get; private set; }

        [Display(Name = "Imagen")]
        public string NombreImagen { get; set; }
        
        [NotMapped]
        public IFormFile ImagenSubir { get; set; }
    }
}