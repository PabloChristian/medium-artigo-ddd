using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SG.Cadastros.Domain;

namespace SG.Cadastros.Application.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GrupoFamiliaController : ControllerBase
    {
        private readonly ILogger<GrupoFamiliaController> _logger;

        public GrupoFamiliaController(ILogger<GrupoFamiliaController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public GrupoFamiliaEntity Get()
        {
            return new GrupoFamiliaEntity();
        }
    }
}
