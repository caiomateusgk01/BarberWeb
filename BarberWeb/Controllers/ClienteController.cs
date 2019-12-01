using Domain;
using Microsoft.AspNetCore.Mvc;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarberWeb.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ClienteDAO _clienteDAO;
        public ClienteController(ClienteDAO clienteDAO)
        {
            _clienteDAO = clienteDAO;
        }
        public ActionResult Index()
        {
            ViewBag.DataHora = DateTime.Now;
            return View(_clienteDAO.ListarTodos());
        }

        public ActionResult Listar()
        {
            ViewBag.DataHora = DateTime.Now;
            return View(_clienteDAO.ListarTodos());
        }

        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar(Cliente c)
        {
            if (ModelState.IsValid)
            {
                if (_clienteDAO.Cadastrar(c))
                {
                    return RedirectToAction("Index");
                }
                ModelState.AddModelError("", "Esse Cliente já existe");
                return View(c);
            }
            return View(c);
        }

        public IActionResult ListarClientes()
        {
            var produtos = _clienteDAO.ListarTodos();
            _clienteDAO.ListarTodos();
            return View(produtos);

        }

        public IActionResult Remover(int? id)
        {
            if (id != null)
            {

                _clienteDAO.RemoverCliente(id);
            }
            else
            {
                //Redirecionar para uma página de erro
            }
            //Remover o produto
            return RedirectToAction("Index");
        }

        public IActionResult Edit()
        {
            return View("Edit");
        }
        [HttpPost]
        public IActionResult Edit(int? id)
        {
            //Remover o produto
            return RedirectToAction("Edit");
        }

    }
}
