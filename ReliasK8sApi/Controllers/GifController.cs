using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ReliasK8sDemoApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GifController : ControllerBase
    {
        private readonly ILogger<GifController> _logger;

        private readonly string[] _gifList = new string[]
        {
            "https://giphy.com/embed/lMVNl6XxTvXgs",
            "https://giphy.com/embed/9oF7EAvaFUOEU",
            "https://giphy.com/embed/Qa5dsjQjlCqOY",
            "https://giphy.com/embed/5wWf7H89PisM6An8UAU",
            "https://giphy.com/embed/dEdmW17JnZhiU",
            "https://giphy.com/embed/dE8BENPVMXoqc",
            "https://giphy.com/embed/l2Sqf1Y2g9C3F97kA",
            "https://giphy.com/embed/6cFcUiCG5eONW"

        };

        public GifController(ILogger<GifController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            var rng = DateTime.Now.Second % 8;

            return _gifList[rng];
        }
    }
}