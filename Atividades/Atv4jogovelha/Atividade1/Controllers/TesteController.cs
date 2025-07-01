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

        [HttpPost]
        public IActionResult Index(string texto)
        {
            Result resultado = new Result();
           // string novo;
            // resultado.Texto = texto.ToUpper();
            for (int i = 0; i < texto.Length; i++)
            { 
               // novo.Append(texto[i] + 3.ToString()); 

            }
           // resultado.Texto = novo;

                return View("Index", resultado);
        }

        [HttpGet]
        public string GetForeach(string color)
        {
            /* O comando foreach(para cada) é utilizado para iterar por uma sequência de itens 
             em uma coleção e servir como uma opção simples de repetição.*/

            string[] colors = { "Vermelho", "Preto", "Azul", "Amarelo","Verde","Branco","Azul-Marinho", "Rosa","Roxo","Cinza"};

           string retorno = string.Empty;

          /*  if (colors.Contains(color[0])+ color.Substring(1))
                retorno = "A cor escikuda pe válida";
            else
                retorno="Cor escolhida inválida";
          */
            foreach(String s in colors)
            {
                retorno += s;
            }

            return retorno;
        }
    }
}
