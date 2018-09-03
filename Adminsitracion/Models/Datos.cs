using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Adminsitracion.Models
{
    public class Datos
    {
        [Required(ErrorMessage = "el siguiente dato es el que requiero")]
        public String nombre { get; set; }

        [Required(ErrorMessage = "el siguiente dato es el que requiero")]
        public String apellido { get; set; }

        [Required(ErrorMessage = "el siguiente dato es el que requiero")]
        public String edad { get; set; }


    }
}