using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SG.Cadastros.Domain;

namespace SG.Produtos.Application.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CadastroProdutoController : ControllerBase
    {
        private readonly ILogger<CadastroProdutoController> _logger;

        public CadastroProdutoController(ILogger<CadastroProdutoController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ProdutoEntity Get()
        {
            return new ProdutoEntity();
        }
    }
}
