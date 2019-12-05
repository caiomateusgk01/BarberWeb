using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain;
using Repository;

namespace BarberWeb.Controllers {
    public class VendaController : Controller {
        private readonly Context _context;
        private readonly ClienteDAO _clienteDAO;
        private readonly FuncionarioDAO _funcionarioDAO;
        private readonly VendaDAO _vendaDAO;
        private readonly ProdutoDAO _produtoDAO;
        private readonly VendaItensDAO _vendasItemDAO;
        private List<dynamic> produtos = new List<dynamic>();

        public VendaController(Context context, ClienteDAO clienteDAO,
            FuncionarioDAO funcionarioDAO, VendaDAO vendaDAO,
            ProdutoDAO produtoDAO, VendaItensDAO vendasItemDAO) {
            _context = context;
            _clienteDAO = clienteDAO;
            _vendaDAO = vendaDAO;
            _funcionarioDAO = funcionarioDAO;
            _produtoDAO = produtoDAO;
            _vendasItemDAO = vendasItemDAO;
        }

        // GET: Venda
        public async Task<IActionResult> Index() {
            return View(_vendaDAO.ListarTodos());
        }

        // GET: Venda/Details/5
        public async Task<IActionResult> Details(int? id) {
            if (id == null) {
                return NotFound();
            }

            var venda = await _context.Vendas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (venda == null) {
                return NotFound();
            } 

            return View(venda);
        }

        // GET: Venda/Create
        public IActionResult Create() {
            ViewBag.Clientes = new SelectList
              (_clienteDAO.ListarTodos(), "Id", "Nome");
            ViewBag.Funcionarios = new SelectList
                (_funcionarioDAO.ListarTodos(), "Id", "Nome");
            ViewBag.Produtos = new SelectList
                (_produtoDAO.ListarTodos(), "ProdutoId", "Nome");
            return View();
        }

        // POST: Venda/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Id,Criadoem")] Venda venda,
            int drpClientes, int drpFuncionarios, int drpProdutos, int drpVendasItem) {

            Produto p = _produtoDAO.BuscarPorId(drpProdutos);

            ViewBag.Clientes = new SelectList
              (_clienteDAO.ListarTodos(), "Id", "Nome");
            ViewBag.Funcionarios = new SelectList
                (_funcionarioDAO.ListarTodos(), "Id", "Nome");
            ViewBag.Produtos = new SelectList
                (_produtoDAO.ListarTodos(), "ProdutoId", "Nome");

            if (ModelState.IsValid) {
                venda.idCliente = _clienteDAO.BuscarPorId(drpClientes);
                venda.idFuncionario = _funcionarioDAO.BuscarPorId(drpFuncionarios);
                venda.Produtos = _produtoDAO.BuscarPorId(drpProdutos);

                _vendaDAO.Cadastrar(venda);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(venda);
        }

        // GET: Venda/Edit/5
        public async Task<IActionResult> Edit(int? id) {
            if (id == null) {
                return NotFound();
            }

            var venda = await _context.Vendas.FindAsync(id);
            if (venda == null) {
                return NotFound();
            }
            return View(venda);
        }

        // POST: Venda/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Criadoem")] Venda venda) {
            if (id != venda.Id) {
                return NotFound();
            }

            if (ModelState.IsValid) {
                try {
                    _context.Update(venda);
                    await _context.SaveChangesAsync();
                } catch (DbUpdateConcurrencyException) {
                    if (!VendaExists(venda.Id)) {
                        return NotFound();
                    } else {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(venda);
        }

        // GET: Venda/Delete/5
        public async Task<IActionResult> Delete(int? id) {
            if (id == null) {
                return NotFound();
            }

            var venda = await _context.Vendas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (venda == null) {
                return NotFound();
            }

            return View(venda);
        }

        // POST: Venda/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id) {
            var venda = await _context.Vendas.FindAsync(id);
            _context.Vendas.Remove(venda);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VendaExists(int id) {
            return _context.Vendas.Any(e => e.Id == id);
        }
    }
}
