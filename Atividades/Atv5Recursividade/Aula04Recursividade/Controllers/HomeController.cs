using System.Diagnostics;
using Aula04Recursividade.Models;
using Microsoft.AspNetCore.Mvc;

namespace Aula04Recursividade.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public string PrintNaturalFor(int n = 10)
        {
            string retorno = string.Empty;

            int i = 1;

            while (i <= n)
            {
                retorno += $" {i} ";
                i++;
            }

            return retorno;
        }

        public string PrintNaturalRecursion(int count = 10)
        {
            string retorno = "";

            retorno = NaturalNumberRecursion(1, count);

            return retorno;
        }

        public string NaturalNumberRecursion(int n, int count)
        {
            string ret = string.Empty;

            //Caso base: Se o contador for menor que 1 
            if (count <= 1)
                return $" {n} ";

            ret += $" {n} ";
            count--; //decrementa count

            //chamada recursiva: incrementa n e decrementa count para imprimi o número
            ret += NaturalNumberRecursion(n + 1, count);

            return ret;
        }

        //atividade 1) Escreva um program recursivo em C sharp para imprimir os números de n até 1(decrescente)
        public string PrintNaturalRecursionDecrescente(int count = 10)
        {
            string retorno = "";

            retorno = NaturalNumberRecursionDecrescente(1, count);

            return retorno;
        }

        public string NaturalNumberRecursionDecrescente(int n, int count)
        {
            string ret = string.Empty;

            //Caso base: Se o contador for menor que 1 
            if (count <= 1)
                return $" {n} ";

            ret += $" {count} ";
            count--; //decrementa count

            //chamada recursiva: incrementa n e decrementa count para imprimi o número
            ret += NaturalNumberRecursionDecrescente(n + 1, count);

            return ret;
        }
        //atividade 2) Escreva um programa em C# capaz de sumarizar os númerso de 1 a n por exemplo: n = 10(1+2+3+4+5+6+7+8+9+10)
        //atividade 3) Escreva um program recursivo em C# capaz de contar quantos caracteres tem em uma string
        //atividade 4) Escreva um programa recursivo que seja capaz de identificar se uma palavra é ou não um Palíndromo ex: ovo, arara, mussum, radar, etc.
    }
}
