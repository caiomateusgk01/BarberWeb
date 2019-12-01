using Domain;
using Microsoft.AspNetCore.Mvc;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarberWeb.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly ProdutoDAO _produtoDAO;
        public ProdutoController(ProdutoDAO produtoDAO)
        {
            _produtoDAO = produtoDAO;
        }
        //Métodos dentro de um controller são chamados
        //de Actions
        public ActionResult Index()
        {
            ViewBag.DataHora = DateTime.Now;
            return View(_produtoDAO.ListarTodos());
        }

        public ActionResult Listar()
        {
            ViewBag.DataHora = DateTime.Now;
            return View(_produtoDAO.ListarTodos());
        }

        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar(Produto p)
        {
            if (ModelState.IsValid)
            {
                if (_produtoDAO.Cadastrar(p))
                {
                    return RedirectToAction("Index");
                }
                ModelState.AddModelError("", "Esse produto já existe");
                return View(p);
            }
            return View(p);
        }

        public IActionResult ListarProdutos()
        {
            var produtos = _produtoDAO.ListarTodos();
            _produtoDAO.ListarTodos();
            return View(produtos);

        }

        public IActionResult EditarProdutos(Produto p)
        {
            _produtoDAO.AlterarProduto(p);
            return View();
        }
        public IActionResult Remover(int? id, Produto p)
        {
            if (id != null)
            {

                _produtoDAO.RemoverProduto(id);
            }
            else
            {
                //Redirecionar para uma página de erro
            }
            //Remover o produto
            return RedirectToAction("Index");
        }
        public IActionResult Alterar(int? id)
        {
            return View(_produtoDAO.BuscarPorId(id));
        }
        [HttpPost]
        public IActionResult Alterar(Produto p)
        {

            _produtoDAO.AlterarProduto(p);
            return RedirectToAction("Index");
        }
    }
}
