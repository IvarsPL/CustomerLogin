using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace ER.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;


        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public List<string> Pakalpojumi = new List<string>()
        {
            "Hair",
            "Nails",
            "Massage",
            "SPA",
            "Beauticians",
            "Products"
        };
    }
}
