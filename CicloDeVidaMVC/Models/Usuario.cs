using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CicloDeVidaMVC.Models
{
    // Usuario Model
    public class Usuario
    {
        [Required]
        [DisplayName("Nombre")]
        public string Nombre { get; set; }
        [DisplayName("Apellidos")]
        public string Apellidos { get; set; }
        [DisplayName("Edad")]
        public int Edad { get; set; }
        [DisplayName("País")]
        public string Pais { get; set; }
    }
}