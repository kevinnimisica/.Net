using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class UsuarioModelo
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public Boolean ConfirmacionEmail { get; set; }
        public string UserName { get; set; }
        public string secStamp { get; set; }
        public UsuarioModelo()
        {

        }
    }
}
