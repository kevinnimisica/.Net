using Modelo;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class DepartamentoLogica
    {
        public List<DepartamentoModel> getListadoDepartamentos()
        {
            try
            {
                var repositorio = new DepartamentoRepositorio();
                var listado = repositorio.GetListadoDepartamentos();
                return listado;
            }
            catch (Exception)
            {
                return new List<DepartamentoModel>();
            }
        }
        public List<DepartamentoModel> getDepartamentoXPais(int? id)
        {
            var lista = getListadoDepartamentos();
            List<DepartamentoModel> retorno = new List<DepartamentoModel>();
            foreach (var item in lista)
            {
                if (item.PaisId == id)
                {
                    retorno.Add(item);
                }
            }
            return retorno;
        }
        public void agregarDept(DepartamentoModel dept)
        {
            try
            {
                var repositorio = new DepartamentoRepositorio();
                repositorio.createDepartamento(dept);
            }
            catch (Exception)
            {
            }
        }

        public DepartamentoModel obtenerDept(int? id)
        {
            var lista = getListadoDepartamentos();
            foreach (var item in lista)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }

        public void editarPais(int id, DepartamentoModel dept)
        {
            using (var db = new JaverianaNetEntities1())
            {
                var result = db.Departamento.SingleOrDefault(d => d.id == dept.Id);
                if (result != null)
                {
                    result.NombreDepartamento = dept.NombreDepartamento;
                    result.PaisId = dept.PaisId;
                    db.SaveChanges();
                }
            }
        }

        public void eliminarDept(int id, DepartamentoModel dept)
        {
            using (var db = new JaverianaNetEntities1())
            {
                var de = new Departamento();
                de.id = dept.Id;
                de.NombreDepartamento = dept.NombreDepartamento;
                de.PaisId = dept.PaisId;
                db.Departamento.Attach(de);
                db.Departamento.Remove(de);
                db.SaveChanges();
            }
        }
    }
}
