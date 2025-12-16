using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;
using EjercicioApi = GymProgressTracker.Models.API.Ejercicio;
using EjercicioMvc = GymProgressTracker.Models.MVC.Ejercicio;

public class EjerciciosController : Controller
{
    private readonly string apiBase = "https://localhost:44373/api/gym/";

    private async Task<List<EjercicioMvc>> ObtenerEjerciciosAsync()
    {
        using (var client = new HttpClient())
        {
            var resp = await client.GetAsync(apiBase + "ejercicios");
            if (!resp.IsSuccessStatusCode) 
                return new List<EjercicioMvc>();
            var listaApi = await resp.Content.ReadAsAsync<List<EjercicioApi>>();
            return listaApi.Select(e => new EjercicioMvc
            {
                Id = e.Id,
                Nombre = e.Nombre,
                GrupoMuscular = e.GrupoMuscular,
                Descripcion = e.Descripcion
            }).ToList();
        }
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<ActionResult> Agregar(string Nombre, string GrupoMuscular, string Descripcion)
    {
        if (!string.IsNullOrWhiteSpace(Nombre) && !string.IsNullOrWhiteSpace(GrupoMuscular))
        {

            var ejercicioApi = new EjercicioApi
            {
                Nombre = Nombre,
                GrupoMuscular = GrupoMuscular,
                Descripcion = Descripcion
            };

            using (var client = new HttpClient())
            {
                var resp = await client.PostAsJsonAsync(apiBase + "ejercicios", ejercicioApi);
                if (resp.IsSuccessStatusCode)
                {
                    TempData["MensajeExito"] = "¡Ejercicio agregado!";
                    return RedirectToAction("Index");
                }
                TempData["MensajeError"] = "Error al agregar el ejercicio.";
            }
        }
        else
        {
            TempData["MensajeError"] = "Debes completar nombre y grupo muscular.";
        }

        var ejercicios = await ObtenerEjerciciosAsync();
        return View("Index", ejercicios);
    }



    // GET: Ejercicios
    public async Task<ActionResult> Index()
    {
        var ejercicios = await ObtenerEjerciciosAsync();
        return View(ejercicios);
    }
}