using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Clase1.Properties
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaControlador : ControllerBase
    {


        // POST api/<PersonaControlador>
        [HttpPost]
        public Persona Post(Persona persona)
        {

           return persona;
                
         }

    }
}
