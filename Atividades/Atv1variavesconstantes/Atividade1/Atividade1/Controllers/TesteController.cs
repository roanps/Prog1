using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Atividade1.Controllers
{
     public class Result
     {
        public string? Texto;
     }
    public class TesteController : Controller
    {
        private readonly ILogger<TesteController> _logger;

        public TesteController(ILogger<TesteController> logger       )
        {
            _logger = logger;
        }

       [HttpGet]
        public IActionResult Index()
        {
            return View("Index", new Result()   );
        }

        
    }
}
