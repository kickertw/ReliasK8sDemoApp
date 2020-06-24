using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ReliasK8sDemoApp.Controllers;

namespace ReliasK8sApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthCheckController : ControllerBase
    {
        private readonly ILogger<GifController> _logger;

        public HealthCheckController(ILogger<GifController> logger)
        {
            _logger = logger;
        }

        public string Get()
        {
            _logger.Log(LogLevel.Information, "Health Check OK!");
            return "🌮🌮🌮";
        }
    }
}