using Modelo;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class CiudadLogica
    {
        public List<CiudadesModel> getListadoCiudades()
        {
            try
            {
                var repositorio = new CiudadRepositorio();
                var listado = repositorio.GetListadoCiudades();
                return listado;
            }
            catch (Exception)
            {
                return new List<CiudadesModel>();
            }
        }
        public List<CiudadesModel> getCiudadesXDepartamento(int? id)
        {
            var lista = getListadoCiudades();
            List<CiudadesModel> retorno = new List<CiudadesModel>();
            foreach (var item in lista)
            {
                if (item.DepartamentoId == id)
                {
                    retorno.Add(item);
                }
            }
            return retorno;
        }
        public CiudadesModel obtenerCiudad(int? id)
        {
            var listado = getListadoCiudades();
            foreach (var item in listado)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }
        public void CreateCiudad(CiudadesModel ciudad)
        {
            var repo = new CiudadRepositorio();
            repo.CreateCiudad(ciudad);
        }

        public void editarCiudad(int id, CiudadesModel ciudad)
        {
            using (var db = new JaverianaNetEntities1())
            {
                var result = db.Ciudades.SingleOrDefault(c => c.id == ciudad.Id);
                if (result != null)
                {
                    result.NombreCiudad = ciudad.NombreCiudad;
                    result.DepartamentoId = ciudad.DepartamentoId;
                    db.SaveChanges();
                }
            }
        }

        public void eliminarCiudad(int id, CiudadesModel ciudad)
        {
            using (var db = new JaverianaNetEntities1())
            {
                var ci = new Ciudades();
                ci.id = ciudad.Id;
                ci.NombreCiudad = ciudad.NombreCiudad;
                ci.DepartamentoId = ciudad.DepartamentoId;
                db.Ciudades.Attach(ci);
                db.Ciudades.Remove(ci);
                db.SaveChanges();
            }
        }
    }
}
