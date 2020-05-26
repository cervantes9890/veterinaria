using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Veterinaria.Web.Models
{
    public class Veterinary
    {
        public int Id { set; get; }
        [Display(Name = "Descripcion")]
        public string Descripcion { set; get; }
      
        public ICollection<Consult> Consults { set; get; }
        public ApplicationUser ApplicationUser { set; get; }

    }
}