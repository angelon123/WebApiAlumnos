using Microsoft.AspNetCore.Mvc;
using WebApiAlumnos.Entidades;

namespace WebApiAlumnos.Controllers
{
   [ApiController ]
   [Route("api/alumnos") ]
    public class AlumnosController : Controllerbase
    {
        [HttpGet]

        public ActionResult<List<Alumno>> Get()
        {
            return new List<Alumno>()
            {
                 new Alumno() {Id = 1, Nombre = "Angel"},
                 new Alumno() {Id = 2, Nombre = "Armando"}
            };


        }








    }
}
