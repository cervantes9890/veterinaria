using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Veterinaria.Web.Models
{
    public class Pet
    {
        public int Id { set; get; }
        [Required]
        [Display(Name = "Nombre")]
        [MaxLength(100)]
        public string Name { set; get; }
        [Display(Name = "Tipo")]
        [Required]
        [MaxLength(50)]
        public string PetType { set; get; }
        [Display(Name = "Edad")]
        public int Age { set; get; }
        [Display(Name = "Fecha De Nacimiento")]
        public DateTime birthDate { set; get; }
        [Display(Name = "Color")]
        [Required]
        [MaxLength(50)]
        public string Color { set; get; }
        [Display(Name = "Raza")]
        [MaxLength(50)]
        public string Race { set; get; }
        [Required]
        [Display(Name = "Peso")]
        public Decimal weight { set; get; }
        [Required]
        [Display(Name = "Altura")]
        public Decimal Heigth { set; get; }
        public Decimal Owner { set; get; }

        public ICollection<Consult> Consults { set; get; }



    }
}