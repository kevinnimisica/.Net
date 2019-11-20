using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class PaisModel
    {

        public int Id { get; set; }
        public string NombrePais { get; set; }
        public PaisModel()
        {

        }
        public PaisModel(int id, string nombre)
        {
            Id = id;
            NombrePais = nombre;
        }
    }
}
