using System.Collections.Generic;
using System;

namespace GymProgressTracker.Models.MVC
{
    public class HistorialEstadisticasViewModel
    {
        public List<RegistroEntrenamiento> Registros { get; set; }
        public List<Ejercicio> Ejercicios { get; set; }
        public int TotalSesiones { get; set; }
        public double MaxPeso { get; set; }
        public int TotalSeries { get; set; }
    }
}