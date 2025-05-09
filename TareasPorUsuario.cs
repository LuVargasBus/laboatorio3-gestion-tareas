﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio3_gestion_tareas
{
    public class TareasPorUsuario
    {
        public Usuario usuario;
        public Tareas tareas;

        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string ApellidoUsuario { get; set; }

        public int IdTarea { get; set; }
        public string NombreTarea { get; set; }
        public string CategoriaTarea { get; set; }
        public string DescripcionTarea { get; set; }
        public string PrioridadTarea { get; set; }
        public DateTime VencimientoTarea { get; set; }

        public string FechaAsignacion { get; set; }
    }
   





   
}
