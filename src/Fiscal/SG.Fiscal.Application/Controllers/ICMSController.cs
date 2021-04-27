using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SG.Fiscal.Domain;

namespace SG.Fiscal.Application.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ICMSController : ControllerBase
    {
        private readonly ILogger<ICMSController> _logger;

        public ICMSController(ILogger<ICMSController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ICMSEntity Get()
        {
            return new ICMSEntity();
        }
    }
}
