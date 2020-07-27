using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace copadefilmes_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogoController : ControllerBase
    {
        private readonly IHttpClientFactory _clientFactory;

        public CatalogoController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        // GET: api/Catalogo
        [HttpGet]
        public Task<string> Get()
        {
            var client = _clientFactory.CreateClient();
            return client.GetStringAsync("http://copafilmes.azurewebsites.net/api/filmes");
        }
    }
}
