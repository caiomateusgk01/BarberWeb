using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain;
using Repository;

namespace BarberWeb.Controllers
{
    public class AgendaController : Controller
    {
        private readonly Context _context;
        private readonly AgendaDAO _agendaDAO;
        private readonly ClienteDAO _clienteDAO;
        private readonly FuncionarioDAO _funcionarioDAO;

        public AgendaController(Context context, AgendaDAO agendaDAO, ClienteDAO clienteDAO, FuncionarioDAO funcionarioDAO)
        {
            _context = context;
            _clienteDAO = clienteDAO;
            _funcionarioDAO = funcionarioDAO;
            _agendaDAO = agendaDAO;
        }

        // GET: Agenda
        public async Task<IActionResult> Index()
        {
            ViewBag.DataHora = DateTime.Now;
            return View(_agendaDAO.ListarTodos());
        }

        // GET: Agenda/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var agenda = await _context.Agendas.Include("Clientes").Include("Funcionario")
                .FirstOrDefaultAsync(m => m.Id == id);
            if (agenda == null)
            {
                return NotFound();
            }

            return View(agenda);
        }

        // GET: Agenda/Create
        public IActionResult Create()
        {
            ViewBag.Clientes = new SelectList
             (_clienteDAO.ListarTodos(), "Id", "Nome");
            ViewBag.Funcionarios = new SelectList
                (_funcionarioDAO.ListarTodos(), "Id", "Nome");
            return View();
        }

        // POST: Agenda/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,HrInicial,Data")] Agenda agenda, int drpCliente, int drpFuncionario)
        {
            ViewBag.Clientes = new SelectList
             (_clienteDAO.ListarTodos(), "Id", "Nome");
            ViewBag.Funcionarios = new SelectList
                (_funcionarioDAO.ListarTodos(), "Id", "Nome");
            if (ModelState.IsValid)
            {
                agenda.Cliente = _clienteDAO.BuscarPorId(drpCliente);
                agenda.Funcionario = _funcionarioDAO.BuscarPorId(drpFuncionario);
                _context.Add(agenda);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(agenda);
        }

        // GET: Agenda/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var agenda = await _context.Agendas.FindAsync(id);
            if (agenda == null)
            {
                return NotFound();
            }
            return View(agenda);
        }

        // POST: Agenda/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,HrInicial,Data")] Agenda agenda)
        {
            if (id != agenda.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(agenda);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AgendaExists(agenda.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(agenda);
        }

        // GET: Agenda/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var agenda = await _context.Agendas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (agenda == null)
            {
                return NotFound();
            }

            return View(agenda);
        }

        // POST: Agenda/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var agenda = await _context.Agendas.FindAsync(id);
            _context.Agendas.Remove(agenda);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AgendaExists(int id)
        {
            return _context.Agendas.Any(e => e.Id == id);
        }
    }
}
