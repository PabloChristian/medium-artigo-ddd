using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SG.Vendas.Domain;

namespace SG.Vendas.Application.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PedidoVendaController : ControllerBase
    {
        private readonly ILogger<PedidoVendaController> _logger;

        public PedidoVendaController(ILogger<PedidoVendaController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public PedidoVendaEntity Get()
        {
            return new PedidoVendaEntity();
        }
    }
}
