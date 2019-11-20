using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio;

namespace Logica
{
    public class UsuarioLogica
    {
        AspNetUserRepositorio repositorio = new AspNetUserRepositorio();
        public List<UsuarioModelo> getListadoUsuarios()
        {
            try
            {
                var listado = repositorio.obtenerUsuarios();
                return listado;
            }
            catch (Exception)
            {
                return new List<UsuarioModelo>();
            }
        }

        public void agregarUsuario(UsuarioModelo usuario)
        {
            repositorio.createUsuario(usuario);
        }

        public UsuarioModelo obtenerUsuario(string id)
        {
            var lista = getListadoUsuarios();
            foreach (var item in lista)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }

        public void editarUsuario(string id, UsuarioModelo user)
        {
            using (var db = new JaverianaNetEntities1())
            {
                var result = db.AspNetUsers.SingleOrDefault(u => u.Id == user.Id);
                if (result != null)
                {
                    result.Email = user.Email;
                    result.EmailConfirmed = user.ConfirmacionEmail;
                    result.UserName = user.UserName;
                    result.SecurityStamp = user.secStamp;
                    db.SaveChanges();
                }
            }
        }
        public void eliminarUsuario(string id, UsuarioModelo user)
        {
            using (var db = new JaverianaNetEntities1())
            {
                var ci = new AspNetUsers();
                
                db.AspNetUsers.Attach(ci);
                db.AspNetUsers.Remove(ci);
                db.SaveChanges();
            }
        }
    }
}
