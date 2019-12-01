using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository
{
    public class ProdutoDAO : IRepository<Produto>
    {
        private readonly Context _context;
        public ProdutoDAO(Context context)
        {
            _context = context;
        }
       

        public  bool Cadastrar(Produto p)
        {
            if (BuscarProdutoNome(p) == null)
            {
                _context.Produtos.Add(p);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        public  List<Produto> ListarTodos() => _context.Produtos.Include("Categoria").ToList();
        public  Produto BuscarProdutoNome(Produto p)
        {
            //FirstOrDefault : é o metodo que retorna um objeto na buca(Primeiro Objeto)
            //SingleOrDefault : é o metodo que retorna um obejo na busca(Retorna uma excesão se tiver objeto com mesmo nome)
            return _context.Produtos.FirstOrDefault
                 (x => x.Nome.Equals(p.Nome));

        }
        public Produto BuscarPorId(int? id)
        {
            //FirstOrDefault : é o metodo que retorna um objeto na buca(Primeiro Objeto)
            //SingleOrDefault : é o metodo que retorna um obejo na busca(Retorna uma excesão se tiver objeto com mesmo nome)
            return _context.Produtos.Find(id);
        }
        public  Produto BuscarProdutoPorData(DateTime data)
        {
            return _context.Produtos.FirstOrDefault
            (x => x. criadoEm.Day == data.Day &&
            x.criadoEm.Month == data.Month &&
            x.criadoEm.Year == data.Year);
        }
        public  List<Produto> BuscarProdutosPorParteNome(Produto p)
        {
            //Where : é o metodo que retorna todas 
            // ocorrencias em uma buscar 
            // Any() : é o método que retorna se existe algum registro na busca.
            // Count() : é método que retorna a quantidade de itens dentro de uma busca.
            return _context.Produtos.Where
                (x => x.Nome.Contains(p.Nome)).ToList();
        }

        public void RemoverProduto(int? id)
        {
            _context.Produtos.Remove(BuscarPorId(id));
            _context.SaveChanges();
        }
        public  void AlterarProduto(Produto p)
        {
            _context.Produtos.Update(p);
            _context.SaveChanges();
        }

    }
}
