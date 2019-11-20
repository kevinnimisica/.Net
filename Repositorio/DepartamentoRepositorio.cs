using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Repositorio
{
    public class DepartamentoRepositorio
    {
        public List<DepartamentoModel> GetListadoDepartamentos()
        {
            using (var contexto = new JaverianaNetEntities1())
            {
                var listado = contexto.Departamento.Select(c => new DepartamentoModel
                {
                    Id = c.id,
                    NombreDepartamento = c.NombreDepartamento,
                    PaisId = c.PaisId
                }).ToList();
                return listado;
            }
        }

        public void createDepartamento(DepartamentoModel dept)
        {
            using (var contexto = new JaverianaNetEntities1())
            {
                var de = new Departamento();
                de.id = dept.Id;
                de.NombreDepartamento = dept.NombreDepartamento;
                de.PaisId = dept.PaisId;
                contexto.Departamento.Add(de);
                contexto.SaveChanges();
                return;
            }
        }
    }
}
