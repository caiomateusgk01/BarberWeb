using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Domain;
using Repository;
using Microsoft.AspNetCore.Cors;

namespace API.Controllers {

    [Route("api/[controller]")]
    public class VendaController : ControllerBase {

        private readonly Context _context;

        public VendaController(Context context) {
            _context = context;
        }

        // POST: api/Venda
        [HttpPost]
        public async Task<IActionResult> PostVenda([FromBody] Venda venda) {

            _context.Vendas.Add(venda);
            await _context.SaveChangesAsync();

            return Ok(venda);
        }
    }
}