﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio3_gestion_tareas
{
    public class Tareas
    {
        public int IdTarea { get; set; }
        public string NombreTarea { get; set; }
        public string CategoriaTarea { get; set; }
        public string DescripcionTarea { get; set; }
        public string PrioridadTarea { get; set; }
        public DateTime VencimientoTarea { get; set; }
    }
}
