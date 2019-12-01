using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class VendaItensDAO : IRepository<VendaItem>
    {
        private readonly Context _context;
        public VendaItensDAO(Context context)
        {

            _context = context;
        }
        public VendaItem BuscarPorId(int? id)
        {
            return _context.VendaItems.Find(id);
        }

        public bool Cadastrar(VendaItem objeto)
        {
            _context.VendaItems.Add(objeto);
            _context.SaveChanges();
            return true;
        }

        public List<VendaItem> ListarTodos() => _context.VendaItems.ToList();

    }
}
