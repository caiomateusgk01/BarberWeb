using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace BarberWeb.Controllers {
    public class FaturamentoController : Controller {

        private readonly Context _context;

        public FaturamentoController(Context context) {
            _context = context;
        }

        public IActionResult Index() {

            var qtdeVendasNoMes = _context.Vendas.Where(v => v.Criadoem.Month == DateTime.Now.Month && v.Criadoem.Year == DateTime.Now.Year).Count();
            var valorVendasNoMes = _context.VendaItems.Where(v => v.Criadoem.Month == DateTime.Now.Month && v.Criadoem.Year == DateTime.Now.Year).Sum(vi => vi.Preco * vi.Quantidade);
            var qtdeItensVendidosNoMes = _context.VendaItems.Where(v => v.Criadoem.Month == DateTime.Now.Month && v.Criadoem.Year == DateTime.Now.Year).Count();
            var valorMediaDeVendasDiaria = valorVendasNoMes / DateTime.Now.Day;

            ViewBag.qtdeVendasNoMes = qtdeVendasNoMes;
            ViewBag.valorVendasNoMes = valorVendasNoMes;
            ViewBag.qtdeItensVendidosNoMes = qtdeItensVendidosNoMes;
            ViewBag.valorMediaDeVendasDiaria = valorMediaDeVendasDiaria;

            return View();
        }
    }
}