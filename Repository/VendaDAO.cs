using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
   public class VendaDAO
   {

        private readonly Context _context;
        public VendaDAO(Context context)
        {
            _context = context;
        }
        public  List<Venda> ListarTodos() => _context.Vendas.Include("idFuncionario").Include("idCliente").Include("VendasItem.Produtos.Categoria").ToList();

        public  List<Venda> listarvendarporcliente(Venda v)
        {
            return _context.Vendas.Include("VendasItem.Produtos.Categoria").Where(x => x.idCliente.Nome.Equals(v.idCliente.Nome)).ToList();
        }

        public void Cadastrar(Venda venda)
        {

            _context.Vendas.Add(venda);
            _context.SaveChanges();
        }

        public Venda BuscarPorId(int ve)
        {
            return _context.Vendas.Find(ve);
        }

        public  IEnumerable<Venda> consultaVendasCliente(string cpf)
        {
            return (from venda in _context.Vendas.ToList()
                    where venda.idCliente.Cpf == venda.idCliente.Cpf
                    select venda);
        }

    }
}
