using Modelo;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class PaisLogica
    {
        public List<PaisModel> getListadoPaises()
        {
            try
            {
                var repositorio = new PaisRepositorio();
                var listado = repositorio.GetListadoPaises();
                return listado;
            }
            catch (Exception)
            {
                return new List<PaisModel>();
            }
        }
        public void agregarPais(PaisModel pais)
        {
            try
            {
                var repositorio = new PaisRepositorio();
                repositorio.createPais(pais);
                
            }
            catch (Exception)
            {
            }
        }

        public PaisModel obtenerPais(int? id)
        {
            var listado = getListadoPaises();
            foreach (var item in listado)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }

        public void editarPais(int id, PaisModel pais)
        {
            using(var db = new JaverianaNetEntities1())
            {
                var result = db.Pais.SingleOrDefault(p => p.id == pais.Id);
                if (result !=  null)
                {
                    result.NombrePais = pais.NombrePais;
                    db.SaveChanges();
                }
            }
        }

        public void eliminarPais(int id, PaisModel pais)
        {
            using (var db = new JaverianaNetEntities1())
            {
                var pa = new Pais();
                pa.id = pais.Id;
                pa.NombrePais = pais.NombrePais;
                db.Pais.Attach(pa);
                db.Pais.Remove(pa);
                db.SaveChanges();
            }
        }

    }

}
