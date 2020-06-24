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
            "https://giphy.com/embed/Qa5dsjQjlCqOY"
        };

        public GifController(ILogger<GifController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            var rng = DateTime.Now.Second % 3;

            return _gifList[rng];
        }
    }
}