using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio3_gestion_tareas
{
  
    public class Usuario
    {
        public string NombreCompleto => NombreUsuario + " " + ApellidoUsuario;
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string ApellidoUsuario { get; set; }
        public string RolUsuario { get; set; }
    }
}
