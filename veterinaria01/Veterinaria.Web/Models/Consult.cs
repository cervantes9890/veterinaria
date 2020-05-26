using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Veterinaria.Web.Models
{
    public class Consult
    {
        public int Id { set; get; }
        [Required]
        [Display(Name = "Facha de Consulta")]
        public DateTime ConsultDate { set; get; }
        [Required]
        [Display(Name = "Descripcion")]
        public string Descripcion { set; get; }
        [Required]
        [Display(Name = "Tipo De Consulta")]
        public string ConsultType { set; get; }
        public Veterinary Veterinary { set; get; }
        public Pet Pet { set; get; }

    }
}