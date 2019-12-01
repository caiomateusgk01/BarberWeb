using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain;
using Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;

namespace BarberWeb.Controllers
{
    [Authorize]
    public class FuncionarioController : Controller
    {
        private readonly FuncionarioDAO _funcionarioDAO;
        private readonly IHostingEnvironment _hosting;

        public FuncionarioController(FuncionarioDAO funcionarioDAO, IHostingEnvironment hosting)
        {
            _funcionarioDAO = funcionarioDAO;
            _hosting = hosting;

        }
   
        // GET: Funcionario
        public IActionResult Index()
        {
            ViewBag.DataHora = DateTime.Now;
            return View(_funcionarioDAO.ListarTodos());
        }
        public ActionResult Listar()
        {
            ViewBag.DataHora = DateTime.Now;
            return View(_funcionarioDAO.ListarTodos());
        }

        // GET: Funcionario/Create
        // [FuncionarioAuthorization]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Funcionario/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public IActionResult Create(Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {

                if (_funcionarioDAO.Cadastrar(funcionario))
                {
                    return RedirectToAction("Index");
                }
                ModelState.AddModelError("", "Esse funcionario já existe! ");
                return View(funcionario);
            }
            return View(funcionario);
        }
        public IActionResult Remover(int? id)
        {
            if (id != null)
            {

                _funcionarioDAO.RemoverFuncionario(id);
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
        // GET: Funcionario/Edit/5
    }
}
