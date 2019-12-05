using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace BarberWeb.Controllers {
    [Route("api/clientes")]
    [ApiController]
    public class ClienteAPIController : ControllerBase {

        private readonly ClienteDAO _clienteDAO;

        public ClienteAPIController(ClienteDAO clienteDAO) {
            _clienteDAO = clienteDAO;
        }
        [HttpGet]
        public IActionResult Listar() {
            var clientes = _clienteDAO.ListarTodos();
            return Ok(clientes);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult BuscarPorId(int id) {
            var clientes = _clienteDAO.BuscarPorId(id);
            return Ok(clientes);
        }

        [HttpPost]
        public IActionResult Cadastrar([FromBody] Cliente cliente) {
            _clienteDAO.Cadastrar(cliente);
            return Ok(cliente);
        }

        [HttpPut]
        public IActionResult Editar([FromBody] Cliente cliente) {
            //_clienteDAO.AlterarCliente(cliente);
            return Ok(cliente);
        }

    }


}