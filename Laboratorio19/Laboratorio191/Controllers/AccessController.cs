using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
//  Agregar el using para Reply
using Laboratorio191.Models.WS;


// EDITADO
namespace Laboratorio191.Controllers
{
    public class AccessController : ApiController
    {
        // Le dice que este método responde a peticiones GET (obtener datos)
        [HttpGet]
        public Reply HelloWorld()
        {
            Reply oR = new Reply();
            oR.result = 1;
            oR.data = null;
            oR.message = "Mi Hello World en API";
            return oR;
        }
    }
}
