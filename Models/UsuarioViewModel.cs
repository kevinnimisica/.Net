using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_20266787.Models
{
    public class UsuarioViewModel
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public Boolean ConfirmacionEmail { get; set; }
        public string UserName { get; set; }
        public string secStamp { get; set; }
    }
}