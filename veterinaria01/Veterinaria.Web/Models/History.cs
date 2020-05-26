using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Veterinaria.Web.Models
{
    public class History
    {
        public int Id { set; get; }
        public Consult Consult { set; get; }

    }
}