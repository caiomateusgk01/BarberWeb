using Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace BarberWeb.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly UsuarioDAO _usuarioDAO;
        private readonly UserManager<UsuarioLogado> 
            _userManager;
        private readonly SignInManager<UsuarioLogado>
            _signManager;

        public UsuarioController(UsuarioDAO usuarioDAO, UserManager<UsuarioLogado> userManager,
            SignInManager<UsuarioLogado> signInManager)
        {
            _usuarioDAO = usuarioDAO;
            _userManager = userManager;
            _signManager = signInManager;
        }
        public IActionResult Index()
        {
            ViewBag.DataHora = DateTime.Now;
            return View(_usuarioDAO.ListarTodos());
        }

        public IActionResult Cadastrar()
        {
            Usuario u = new Usuario();
            if (TempData["Endereco"] != null)
            {
                string resultado = TempData["Endereco"].ToString();
                Endereco endereco =
                    JsonConvert.DeserializeObject<Endereco>
                    (resultado);
                u.Endereco = endereco;
            }
            return View(u);
        }

        [HttpPost]
        public IActionResult BuscarCep(Usuario u)
        {
            string url = "https://api.postmon.com.br/v1/cep/" +
                u.Endereco.Cep;
            WebClient client = new WebClient();
            TempData["Endereco"] = client.DownloadString(url);

            return RedirectToAction(nameof(Cadastrar));
        }
        [HttpPost]
        public async Task<IActionResult> Cadastrar(Usuario u)
        {
            if (ModelState.IsValid)
            {
                //Criar um objeto do UsuarioLogado e passar                 
                //obrigatoriamente o Email e UserName
                UsuarioLogado usuarioLogado = new UsuarioLogado
                {
                    Email = u.Email,
                    UserName = u.Email
                };
                //Cadastra o usuário na tabela do Identity
                IdentityResult result = await _userManager.CreateAsync(usuarioLogado, u.Senha);
                //Testar o resultado do cadastro
                if (result.Succeeded)
                {
                    //Logar o usuário no sistema
                    await _signManager.SignInAsync(usuarioLogado,
                        isPersistent: false);
                    if (_usuarioDAO.Cadastrar(u))
                    {
                        return RedirectToAction("Login");
                    }
                    ModelState.AddModelError("", "Este e-mail já está sendo utilizado!");
                }
                AdicionarErros(result);
            }
            return View(u);
        }
        private void AdicionarErros(IdentityResult result)
        {
            foreach (var erro in result.Errors)
            {
                ModelState.AddModelError
                    ("", erro.Description);
            }
        }
        public async Task<IActionResult> Logout()
        {
            await _signManager.SignOutAsync();
            return RedirectToAction("Login", "Usuario");
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(Usuario u)
        {
            var result = await _signManager.
                PasswordSignInAsync(u.Email,
                u.Senha, true, lockoutOnFailure: false);
            if (result.Succeeded)
            {
                return RedirectToAction("Create", "Funcionarios");
            }
            ModelState.AddModelError("", "Falha no login!");
            return View();
        }
    }
 }
