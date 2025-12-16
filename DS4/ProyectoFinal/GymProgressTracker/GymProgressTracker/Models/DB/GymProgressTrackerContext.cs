using GymProgressTracker.Models.API;
using System.Collections.Generic;
using System.Data.Entity;

public class GymProgressTrackerContext : DbContext
{
    public GymProgressTrackerContext()
        : base("name=GymProgressTrackerContext")
    {
    }

    public DbSet<Rutina> Rutinas { get; set; }
    public DbSet<Ejercicio> Ejercicios { get; set; }
    public DbSet<RegistroEntrenamiento> RegistrosEntrenamiento { get; set; }
}