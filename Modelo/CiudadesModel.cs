using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class CiudadesModel
    {
        public int Id { get; set; }
        public string NombreCiudad { get; set; }
        public int? DepartamentoId { get; set; }
        public CiudadesModel()
        {

        }
        public CiudadesModel(int id, string nombre, int? departamento)
        {
            Id = id;
            NombreCiudad = nombre;
            DepartamentoId = departamento;
        }
    }
}
