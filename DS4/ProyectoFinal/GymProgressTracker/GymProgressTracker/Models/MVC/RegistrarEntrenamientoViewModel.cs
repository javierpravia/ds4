using System;
using System.Collections.Generic;

namespace GymProgressTracker.Models.MVC
{
    public class RegistrarEntrenamientoViewModel
    {
        public RegistroEntrenamiento NuevoRegistro { get; set; }
        public List<Ejercicio> Ejercicios { get; set; }
        public List<RegistroEntrenamiento> UltimosRegistros { get; set; }
    }
}