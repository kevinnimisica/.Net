using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_20266787.Models
{
    public class CiudadViewModel
    {
        public int Id { get; set; }
        public string NombreCiudad { get; set; }
        public int? DepartamentoId { get; set; }
    }
}