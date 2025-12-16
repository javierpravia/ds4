using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymProgressTracker.Models.API
{
    public class Ejercicio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string GrupoMuscular { get; set; }
        public string Descripcion { get; set; }
    }
}