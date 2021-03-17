using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicShopMVC.Models
{
    public class GuitarraCriolla
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }   
        public string Marca { get; set; }

        public string Linea { get; set; }

        public string Modelo { get; set; }

        public string OrientacionMano { get; set; }

        public int CantidadCuerdas { get; set; }

        public int CantidadTrastes { get; set; }

        public string Origen { get; set; }

        public string MaderaCuerpo { get; set; }  
    }
}
