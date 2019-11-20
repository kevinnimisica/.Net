using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class CiudadRepositorio
    {
        public List<CiudadesModel> GetListadoCiudades()
        {
            using (var contexto = new JaverianaNetEntities1())
            {
                var listado = contexto.Ciudades.Select(c => new CiudadesModel
                {
                    Id = c.id,
                    NombreCiudad = c.NombreCiudad,
                    DepartamentoId = c.DepartamentoId
                }).ToList();
                return listado;
            }
        }

        public void CreateCiudad(CiudadesModel ciudad)
        {
            using (var contexto = new JaverianaNetEntities1())
            {
                var nCiu = new Ciudades();
                nCiu.id = ciudad.Id;
                nCiu.NombreCiudad = ciudad.NombreCiudad;
                nCiu.DepartamentoId = ciudad.DepartamentoId;
                contexto.Ciudades.Add(nCiu);
                contexto.SaveChanges();
            }
        }
    }
}
