using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace MusicShopMVC.Models
{
    [Display(Name = "Instrumentos de cuerda")]
    public class InstrumentoCuerda : ClaseBase
    {
        public Marca Marca { get; set; }
        public int MarcaID { get; set; }

        [Required(ErrorMessage = "Ingrese el modelo")]
        [MaxLength(30)]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "Ingrese la orientación de la mano")]
        [Display(Name = "Orientación de la mano")]
        [MaxLength(10)]
        public string OrientacionMano { get; set; }
        
        [Required(ErrorMessage = "Ingrese la cantidad de cuerdas")]
        [Display(Name = "Cantidad de cuerdas")]
        public int CantidadCuerdas { get; set; }

        [Required(ErrorMessage = "Ingrese el origen")]
        [MaxLength(20)]
        public string Origen { get; set; }

        [Display(Name = "Imagen")]
        public string NombreImagen { get; set; }
        
        [NotMapped]
        public IFormFile ImagenSubir { get; set; }
    }
}