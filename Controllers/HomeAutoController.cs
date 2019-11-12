using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeAutoController : ControllerBase
    {

        [HttpGet]
        public Home Get(int id,int status)
        {
            
            return new Home().ab(id,status);
        }
    }
}
