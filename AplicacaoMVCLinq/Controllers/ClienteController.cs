using AplicacaoMVCLinq.Models;
using Microsoft.AspNetCore.Mvc;

namespace AplicacaoMVCLinq.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetCliente()
        {
            Cliente c1 = new Cliente(1, "Alice", "alice@example.com", "1234-5678", new DateOnly(2000, 6, 1));
            Cliente c2 = new Cliente(2, "Rogério", "rogério@example.com", "1234-5678", new DateOnly(2000, 7, 3));
            Cliente c3 = new Cliente(3, "Carlos", "carlose@example.com", "1234-5678", new DateOnly(1999, 8, 7));
            Cliente c4 = new Cliente(4, "Claudia", "claudia@example.com", "1234-5678", new DateOnly(2000, 12, 10));
            Cliente c5 = new Cliente(5, "Bruno", "brunoe@example.com", "1234-5678", new DateOnly(1996, 10, 9));

            List<Cliente> listaC = new List<Cliente>();
            listaC.Add(c1);
            listaC.Add(c2);
            listaC.Add(c3);
            listaC.Add(c4);
            listaC.Add(c5);

            return View(listaC);
        }

    }

}
