using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository
{
    public class ClienteDAO : IRepository<Cliente>
    {
        private readonly Context _context;
        public ClienteDAO(Context context) {

            _context = context;
        }
  
        public  bool Cadastrar(Cliente c)
        {
            if (BuscarClientePorNome(c) != null)
            {
                return false;
            }

            _context.Clientes.Add(c);
            _context.SaveChanges();
            return true;
        }
        public  List<Cliente> ListarTodos() => _context.Clientes.Include("Funcionario").ToList();

        public  Cliente BuscarClientePorNome(Cliente c)
        {
            return _context.Clientes.FirstOrDefault
                (x => x.Nome.Equals(c.Nome));
        }
        public  List<Cliente> BuscarClientePorParteNome(Cliente c)
        {
            return _context.Clientes.Where
                (x => x.Nome.Contains(c.Nome)).ToList();
        }
        public Cliente BuscarPorId(int? id)
        {
            return _context.Clientes.Find(id);
            
        }
        // C = Objeto 
        public void RemoverCliente(int? id)
        {
            _context.Clientes.Remove(BuscarPorId(id));
            _context.SaveChanges();
        }
        public void AlterarCliente(Cliente c)
        {
            _context.Clientes.Update(c);
            _context.SaveChanges();
        }
    }
}
