using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace WebApplication1.Pages.Home
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [BindProperty]
        public MyData Data { get; set; }

        public IActionResult OnPost()
        {
            string json = JsonConvert.SerializeObject(Data);
            string path = Path.Combine(Directory.GetCurrentDirectory(), "data.json");
            System.IO.File.WriteAllText(path, json);
            return Redirect("/success");
        }
    }
}
