using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;
using RutinaApi = GymProgressTracker.Models.API.Rutina;
using RutinaMvc = GymProgressTracker.Models.MVC.Rutina;

public class RutinasController : Controller
{
    private readonly string apiBase = "https://localhost:44373/api/gym/";

    private async Task<List<RutinaMvc>> ObtenerRutinasAsync()
    {
        using (var client = new HttpClient())
        {
            var resp = await client.GetAsync(apiBase + "rutinas");
            if (!resp.IsSuccessStatusCode) return new List<RutinaMvc>();
            var listaApi = await resp.Content.ReadAsAsync<List<RutinaApi>>();
            return listaApi.Select(r => new RutinaMvc
            {
                Id = r.Id,
                Nombre = r.Nombre,
                Descripcion = r.Descripcion
            }).ToList();
        }
    }

    // GET: Rutinas
    public async Task<ActionResult> Index()
    {
        var rutinas = await ObtenerRutinasAsync();
        return View(rutinas);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<ActionResult> Agregar(string Nombre, string Descripcion)
    {
        if (!string.IsNullOrWhiteSpace(Nombre))
        {
            var rutinaApi = new RutinaApi
            {
                Nombre = Nombre,
                Descripcion = Descripcion
            };

            using (var client = new HttpClient())
            {
                var resp = await client.PostAsJsonAsync(apiBase + "rutinas", rutinaApi);
                if (resp.IsSuccessStatusCode)
                {
                    TempData["MensajeExito"] = "¡Rutina agregada!";
                    return RedirectToAction("Index");
                }
                TempData["MensajeError"] = "Error al agregar la rutina.";
            }
        }
        else
        {
            TempData["MensajeError"] = "El nombre es obligatorio.";
        }
        var rutinas = await ObtenerRutinasAsync();
        return View("Index", rutinas);
    }
}