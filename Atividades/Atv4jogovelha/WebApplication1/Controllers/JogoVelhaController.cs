using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class JogoVelhaController : Controller
    {
        [HttpPost]
        public IActionResult Index(
             string A00, string A01, string A02,
             string A10, string A11, string A12,
             string A20, string A21, string A22
         )
        {
            string[,] matrixJV = new string[3, 3];
            matrixJV[0, 0] = A00;
            matrixJV[0, 1] = A01;
            matrixJV[0, 2] = A02;

            matrixJV[1, 0] = A10;
            matrixJV[1, 1] = A11;
            matrixJV[1, 2] = A12;

            matrixJV[2, 0] = A20;
            matrixJV[2, 1] = A21;
            matrixJV[2, 2] = A22;

            string ganhador = string.Empty;
            if (matrixJV[0, 0] == "X" || matrixJV[0, 1] == "X" || matrixJV[0, 2] == "X")
                ganhador = "X";
            else if (matrixJV[1, 0] == "X" || matrixJV[1, 1] == "X" || matrixJV[1, 2] == "X")
                ganhador = "X";
            else if (matrixJV[2, 0] == "X" || matrixJV[2, 1] == "X" || matrixJV[2, 2] == "X")
                ganhador = "X";
            else if (matrixJV[0, 0] == "X" || matrixJV[1, 0] == "X" || matrixJV[2, 0] == "X")
                ganhador = "X";
            else if (matrixJV[0, 1] == "X" || matrixJV[1, 1] == "X" || matrixJV[2, 1] == "X")
                ganhador = "X";
            else if (matrixJV[0, 2] == "X" || matrixJV[1, 2] == "X" || matrixJV[2, 2] == "X")
                ganhador = "X";
            else if (matrixJV[0, 0] == "X" || matrixJV[1, 1] == "X" || matrixJV[2, 2] == "X")
                ganhador = "X";
            else if (matrixJV[0, 2] == "X" || matrixJV[1, 1] == "X" || matrixJV[2, 0] == "X")
                ganhador = "X";
            else if (matrixJV[0, 0] == "O" || matrixJV[0, 1] == "O" || matrixJV[0, 2] == "O")
                ganhador = "O";
            else if (matrixJV[1, 0] == "O" || matrixJV[1, 1] == "O" || matrixJV[1, 2] == "O")
                ganhador = "O";
            else if (matrixJV[2, 0] == "O" || matrixJV[2, 1] == "O" || matrixJV[2, 2] == "O")
                ganhador = "O";
            else if (matrixJV[0, 0] == "O" || matrixJV[1, 0] == "O" || matrixJV[2, 0] == "O")
                ganhador = "O";
            else if (matrixJV[0, 1] == "O" || matrixJV[1, 1] == "O" || matrixJV[2, 1] == "O")
                ganhador = "O";
            else if (matrixJV[0, 2] == "O" || matrixJV[1, 2] == "O" || matrixJV[2, 2] == "O")
                ganhador = "O";
            else if (matrixJV[0, 0] == "O" || matrixJV[1, 1] == "O" || matrixJV[2, 2] == "O")
                ganhador = "O";
            else if (matrixJV[0, 2] == "O" || matrixJV[1, 1] == "O" || matrixJV[2, 0] == "O")
                ganhador = "O";
            else
                ganhador = "Deu velha";
            return View();
        }
    }
}
