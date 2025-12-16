using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;


using EjercicioApi = GymProgressTracker.Models.API.Ejercicio;
using EjercicioMvc = GymProgressTracker.Models.MVC.Ejercicio;
using RegistroApi = GymProgressTracker.Models.API.RegistroEntrenamiento;
using RegistroMvc = GymProgressTracker.Models.MVC.RegistroEntrenamiento;
using HistorialEstadisticasViewModel = GymProgressTracker.Models.MVC.HistorialEstadisticasViewModel;

public class HistorialEstadisticasController : Controller
{
    private readonly string apiBase = "https://localhost:44373/api/gym/";


    private async Task<List<RegistroMvc>> ObtenerTodosRegistrosAsync()
    {
        using (var client = new HttpClient())
        {
            var resp = await client.GetAsync(apiBase + "registrosentrenamiento");
            if (!resp.IsSuccessStatusCode) return new List<RegistroMvc>();
            var listaApi = await resp.Content.ReadAsAsync<List<RegistroApi>>();
            var listaMvc = listaApi.Select(r => new RegistroMvc
            {
                Id = r.Id,
                EjercicioId = r.EjercicioId,
                Fecha = r.Fecha,
                Peso = r.Peso,
                Series = r.Series,
                Repeticiones = r.Repeticiones,
                Notas = r.Notas
            }).OrderByDescending(r => r.Fecha)
              .ToList();
            return listaMvc;
        }
    }

    private async Task<List<EjercicioMvc>> ObtenerEjerciciosAsync()
    {
        using (var client = new HttpClient())
        {
            var resp = await client.GetAsync(apiBase + "ejercicios");
            if (!resp.IsSuccessStatusCode) return new List<EjercicioMvc>();
            var listaApi = await resp.Content.ReadAsAsync<List<EjercicioApi>>();
            var listaMvc = listaApi.Select(e => new EjercicioMvc
            {
                Id = e.Id,
                Nombre = e.Nombre,
                GrupoMuscular = e.GrupoMuscular,
                Descripcion = e.Descripcion
            }).ToList();
            return listaMvc;
        }
    }


    public async Task<ActionResult> Index()
    {
        var registros = await ObtenerTodosRegistrosAsync();
        var ejercicios = await ObtenerEjerciciosAsync();

        int totalSesiones = registros.Count;
        double maxPeso = registros.Any() ? registros.Max(r => r.Peso) : 0;
        int totalSeries = registros.Sum(r => r.Series);

        var model = new HistorialEstadisticasViewModel
        {
            Registros = registros,
            Ejercicios = ejercicios,
            TotalSesiones = totalSesiones,
            MaxPeso = maxPeso,
            TotalSeries = totalSeries
        };

        return View(model);
    }
}