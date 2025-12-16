using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Mvc;


using EjercicioApi = GymProgressTracker.Models.API.Ejercicio;
using EjercicioMvc = GymProgressTracker.Models.MVC.Ejercicio;
using RegistroApi = GymProgressTracker.Models.API.RegistroEntrenamiento;
using RegistroMvc = GymProgressTracker.Models.MVC.RegistroEntrenamiento;
using RegistrarEntrenamientoViewModel = GymProgressTracker.Models.MVC.RegistrarEntrenamientoViewModel;

public class RegistrarEntrenamientoController : Controller
{
    private readonly string apiBase = "https://localhost:44373/api/gym/";



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



    private async Task<List<RegistroMvc>> ObtenerUltimosRegistrosAsync(int cantidad)
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
            })
            .OrderByDescending(r => r.Fecha)
            .Take(cantidad)
            .ToList();
            return listaMvc;
        }
    }

    private async Task<bool> RegistrarEntrenamientoAsync(RegistroMvc reg)
    {
        using (var client = new HttpClient())
        {
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var regApi = new RegistroApi
            {
                Id = reg.Id,
                EjercicioId = reg.EjercicioId,
                Fecha = reg.Fecha,
                Peso = reg.Peso,
                Series = reg.Series,
                Repeticiones = reg.Repeticiones,
                Notas = reg.Notas
            };
            var resp = await client.PostAsJsonAsync(apiBase + "registrosentrenamiento", regApi);
            return resp.IsSuccessStatusCode;
        }
    }


    public async Task<ActionResult> Index()
    {
        var model = new RegistrarEntrenamientoViewModel
        {
            Ejercicios = await ObtenerEjerciciosAsync(),
            UltimosRegistros = await ObtenerUltimosRegistrosAsync(5),
            NuevoRegistro = new RegistroMvc { Fecha = DateTime.Now }
        };

        return View(model);
    }


    [HttpPost]
    public async Task<ActionResult> Registrar(RegistrarEntrenamientoViewModel model)
    {
        if (model.NuevoRegistro != null && model.NuevoRegistro.EjercicioId > 0)
        {
            if (model.NuevoRegistro.Fecha == default(DateTime))
                model.NuevoRegistro.Fecha = DateTime.Now;

            var ok = await RegistrarEntrenamientoAsync(model.NuevoRegistro);
            System.Diagnostics.Debug.WriteLine("API POST result: " + ok);
            if (ok)
            {
                TempData["MensajeExito"] = "¡Registro guardado!";
                return RedirectToAction("Index");
            }
            TempData["MensajeError"] = "Error al guardar el registro.";
        }
        else
        {
            TempData["MensajeError"] = "Datos inválidos.";
        }


        model.Ejercicios = await ObtenerEjerciciosAsync();
        model.UltimosRegistros = await ObtenerUltimosRegistrosAsync(5);

        return View("Index", model);
    }
}