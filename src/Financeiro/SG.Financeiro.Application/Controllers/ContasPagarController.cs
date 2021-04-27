using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SG.Financeiro.Domain;

namespace SG.Financeiro.Application.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContasPagarController : ControllerBase
    {
        private readonly ILogger<ContasPagarController> _logger;

        public ContasPagarController(ILogger<ContasPagarController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ContasPagarEntity Get()
        {
            return new ContasPagarEntity();
        }
    }
}
