using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PowerController : ControllerBase
    {

        [HttpGet]
        public Power Get()
        {
            
            return new Power().get();
        }
    }
}