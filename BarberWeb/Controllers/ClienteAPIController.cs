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
    public class ClienteAPIController : ControllerBase {

        private readonly ClienteDAO _clienteDAO;

        public ClienteAPIController(ClienteDAO clienteDAO) {
            _clienteDAO = clienteDAO;
        }

        /**
         * Lista todos os clientes.
         * Endereço: /api/clientes/
         * Método: GET
         */
        [HttpGet]
        public IActionResult Listar() {
            var clientes = _clienteDAO.ListarTodos();
            return Ok(clientes);
        }

        /**
         * Lista os dados do cliente que tem o ID passado por parametro.
         * Endereço: /api/clientes/idDoCliente
         * Método: GET
         */
        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id) {
            var clientes = _clienteDAO.BuscarPorId(id);
            return Ok(clientes);
        }

        /**
         * Cadastra um novo cliente.
         * Endereço: /api/clientes/
         * Método: POST
         */
        [HttpPost]
        public IActionResult Cadastrar([FromBody] Cliente cliente) {
            if (ModelState.IsValid) {
                _clienteDAO.Cadastrar(cliente);
                return Ok(cliente);
            } else {
                return BadRequest();
            }
        }

        /**
         * Edita os dados de um cliente já cadastrado.
         * Endereço: /api/clientes/
         * Método: PUT
         */
        [HttpPut]
        public IActionResult Editar([FromBody] Cliente cliente) {
            if (ModelState.IsValid) {
                _clienteDAO.AlterarCliente(cliente);
                return Ok(cliente);
            } else {
                return BadRequest();
            }
        }

        /**
         * Exclui um cliente já cadastrado do banco de dados.
         * Endereço: /api/clientes/ID
         * Método: DELETE
         */
        [HttpDelete("{id}")]
        public IActionResult Excluir(int id) {
            try {
                _clienteDAO.RemoverCliente(id);
                return Ok(new { msg = "Cliente excluido com sucesso!" }); // Ok, foi excluído!
            } catch (Exception) {
                return Conflict(new { msg = "Impossível excluir esse cliente!" }); //Provavelmente tem algum relacionamento, sendo impossível excluir nesse momento0.
            }
        }
    }
}