using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class AspNetUserRepositorio
    {
        public List<UsuarioModelo> obtenerUsuarios()
        {
            using (var contexto = new JaverianaNetEntities1())
            {
                var listado = contexto.AspNetUsers.Select(u => new UsuarioModelo
                {
                    Id = u.Id,
                    Email = u.Email,
                    ConfirmacionEmail = u.EmailConfirmed,
                    UserName = u.UserName,
                    secStamp = u.SecurityStamp
                }).ToList();
                return listado;
            }
        }

        public void createUsuario(UsuarioModelo us)
        {
            using (var contexto = new JaverianaNetEntities1())
            {
                var nUs = new AspNetUsers();
                nUs.Id = us.Id;
                nUs.Email = us.Email;
                nUs.EmailConfirmed = us.ConfirmacionEmail;
                nUs.UserName = us.UserName;
                nUs.SecurityStamp = us.secStamp;
                contexto.AspNetUsers.Add(nUs);
                contexto.SaveChanges();
                return;
            }
        }

    }
}
