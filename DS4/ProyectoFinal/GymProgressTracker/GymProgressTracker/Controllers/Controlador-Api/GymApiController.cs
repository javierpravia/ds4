using GymProgressTracker.Models.API;
using System;
using System.Linq;
using System.Web.Http;


public class GymApiController : ApiController
{

    private GymProgressTrackerContext db = new GymProgressTrackerContext();

    // =============================================================
    // =====================   R U T I N A S   =====================
    // =============================================================


    [HttpGet]
    [Route("api/gym/rutinas")]
    public IHttpActionResult ListarRutinas()
    {
        var lista = db.Rutinas.ToList();
        return Ok(lista);
    }

    // Crear una nueva rutina
    [HttpPost]
    [Route("api/gym/rutinas")]
    public IHttpActionResult CrearRutina([FromBody] Rutina rutina)
    {
        if (rutina == null || string.IsNullOrWhiteSpace(rutina.Nombre))
            return BadRequest("Faltan datos de la rutina.");

        db.Rutinas.Add(rutina);
        db.SaveChanges();
        return Ok(rutina);
    }

    // =============================================================
    // ==================   E J E R C I C I O S   =================
    // =============================================================


    [HttpGet]
    [Route("api/gym/ejercicios")]
    public IHttpActionResult ListarEjercicios()
    {
        var lista = db.Ejercicios.ToList();
        return Ok(lista);
    }


    [HttpPost]
    [Route("api/gym/ejercicios")]
    public IHttpActionResult CrearEjercicio([FromBody] Ejercicio ejercicio)
    {
        if (ejercicio == null || string.IsNullOrWhiteSpace(ejercicio.Nombre) || string.IsNullOrWhiteSpace(ejercicio.GrupoMuscular))
            return BadRequest("Faltan datos del ejercicio.");

        db.Ejercicios.Add(ejercicio);
        db.SaveChanges();
        return Ok(ejercicio);
    }

    // =============================================================
    // ==========   R E G I S T R O S   D E   E N T R E N O   ======
    // =============================================================

    [HttpGet]
    [Route("api/gym/registrosentrenamiento")]
    public IHttpActionResult ListarRegistrosEntrenamiento()
    {
        var lista = db.RegistrosEntrenamiento.ToList();
        return Ok(lista);
    }

    [HttpPost]
    [Route("api/gym/registrosentrenamiento")]
    public IHttpActionResult CrearRegistroEntrenamiento([FromBody] RegistroEntrenamiento registro)
    {
        if (registro == null || registro.EjercicioId <= 0 || registro.Peso <= 0 || registro.Series <= 0 || registro.Repeticiones <= 0)
            return BadRequest("Faltan datos o son incorrectos.");

        if (registro.Fecha == default(DateTime))
            registro.Fecha = DateTime.Now;

        db.RegistrosEntrenamiento.Add(registro);
        db.SaveChanges();
        return Ok(registro);
    }

    // ========================================
    // ========  Liberar recursos  ============
    // ========================================

    protected override void Dispose(bool disposing)
    {
        if (disposing)
            db.Dispose();

        base.Dispose(disposing);
    }
}