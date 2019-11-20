using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class DepartamentoModel
    {

        public int Id { get; set; }
        public string NombreDepartamento { get; set; }
        public int? PaisId { get; set; }

        public DepartamentoModel()
        {

        }
        public DepartamentoModel(int id, string nombre, int? pais)
        {
            Id = id;
            NombreDepartamento = nombre;
            PaisId = pais;
        }
    }
}
