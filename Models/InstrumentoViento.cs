using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace MusicShopMVC.Models
{
    public class InstrumentoViento : ClaseBase
    {
        public Marca Marca { get; set; }
        public int MarcaID { get; set; }

        [Required(ErrorMessage = "Ingrese el modelo")]
        [MaxLength(30)]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "Ingrese el tipo")]
        [MaxLength(30)]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "Ingrese el material")]
        [MaxLength(30)]
        public string Material { get; set; }

        [Display(Name = "Imagen")]
        public string NombreImagen { get; set; }
        
        [NotMapped]
        public IFormFile ImagenSubir { get; set; }
    }
}