using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace ReliasK8sFrontEnd.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IConfiguration _configuration;

        public string GifUrl { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public async Task OnGet()
        {
            using var httpClient = new HttpClient();
            
            try
            {
                _logger.Log(LogLevel.Information, "Accessing API at " + _configuration["ApiUrl"]);
                GifUrl = await httpClient.GetStringAsync(_configuration["ApiUrl"] + "/api/gif");
            }
            catch (Exception e)
            {
                _logger.Log(LogLevel.Error, e.StackTrace);
                GifUrl = "https://giphy.com/embed/H7wajFPnZGdRWaQeu0";
            }
        }
    }
}
