using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using copadefilmes_api.Models;

namespace copadefilmes_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampeonatoController : ControllerBase
    {
        public CampeonatoController() {};

        [HttpPost]
        public async Task<ActionResult<Filme>> NovoCampeonato(List<Filme> filmes)
        {
            
        }

    }
}