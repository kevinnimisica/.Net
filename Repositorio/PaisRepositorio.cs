using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class PaisRepositorio
    {
        public List<PaisModel> GetListadoPaises()
        {
            using (var contexto = new JaverianaNetEntities1())
            {
                var listado = contexto.Pais.Select(c => new PaisModel
                {
                    Id = c.id,
                    NombrePais = c.NombrePais
                }).ToList();
                return listado;
            }
        }

        public void createPais(PaisModel pais)
        {
            using (var contexto = new JaverianaNetEntities1())
            {
                var pai = new Pais();
                pai.id = pais.Id;
                pai.NombrePais = pais.NombrePais;
                contexto.Pais.Add(pai);
                contexto.SaveChanges();
                return ;
            }
        }
        
    }
}
