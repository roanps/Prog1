using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class JogoVelhaController : Controller
    {
        [HttpPost]
        public IActionResult Index()
        {
            var model = new JogoDaVelhaModel();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    var key = $"A{i}{j}";
                    var valor = Request.Form[key];

                    // Valida valor: só aceita 'X' ou 'O', maiúsculo
                    if (!string.IsNullOrEmpty(valor))
                    {
                        var c = char.ToUpper(valor[0]);
                        if (c == 'X' || c == 'O')
                            model.Tabuleiro[i, j] = c;
                        else
                            model.Tabuleiro[i, j] = ' ';
                    }
                    else
                    {
                        model.Tabuleiro[i, j] = ' ';
                    }
                }
            }

            model.VerificarVitoria();

            return View(model);
        }
    }
}