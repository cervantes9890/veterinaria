using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Veterinaria.Web.Models
{
    public class Owner
    {
        public int Id { set; get; }
        public ApplicationUser ApplicationUser { set; get; }


    }
}