using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class CategoriaDAO : IRepository<Categoria>
    {
        private readonly Context _context;
        public CategoriaDAO(Context context)
        {

            _context = context;
        }
        public Categoria BuscarPorId(int? id)
        {
            return _context.Categorias.Find(id);
        }
        public Categoria BuscarCategoriaPorNome(Categoria c)
        {
            return _context.Categorias.FirstOrDefault
                (x => x.Nome.Equals(c.Nome));
        }
        public bool Cadastrar(Categoria c)
        {
            if (BuscarCategoriaPorNome(c) != null)
            {
                return false;
            }

            _context.Categorias.Add(c);
            _context.SaveChanges();
            return true;
        }

        public List<Categoria> ListarTodos() => _context.Categorias.ToList();

        public void RemoverCategoria(int? id)
        {
            _context.Categorias.Remove(BuscarPorId(id));
            _context.SaveChanges();
        }
        public void AlterarCategoria(int? id)
        {
            _context.Categorias.Update(BuscarPorId(id));
            _context.SaveChanges();
        }
    }
}
