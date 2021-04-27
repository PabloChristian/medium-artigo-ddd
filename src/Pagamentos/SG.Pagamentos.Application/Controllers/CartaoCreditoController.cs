using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SG.Pagamentos.Domain;

namespace SG.Pagamentos.Application.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CartaoCreditoController : ControllerBase
    {
        private readonly ILogger<CartaoCreditoController> _logger;

        public CartaoCreditoController(ILogger<CartaoCreditoController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public CartaoCreditoEntity Get()
        {
            return new CartaoCreditoEntity();
        }
    }
}
