using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class FuncionarioDAO : IRepository<Funcionario>
    {
        private readonly Context _context;
        public FuncionarioDAO(Context context)
        {

            _context = context;
        }

        public bool Cadastrar(Funcionario f)
        {
            if (BuscarFuncionarioPorNome(f) != null)
            {
                return false;
            }

            _context.Funcionarios.Add(f);
            _context.SaveChanges();
            return true;
        }
        public List<Funcionario> ListarTodos() => _context.Funcionarios.ToList();


        public Funcionario BuscarFuncionarioPorNome(Funcionario f)
        {
            return _context.Funcionarios.FirstOrDefault
                (x => x.Nome.Equals(f.Nome));
        }
        public List<Funcionario> BuscarFuncionarioPorParteNome(Funcionario f)
        {
            return _context.Funcionarios.Where
                (x => x.Nome.Contains(f.Nome)).ToList();
        }
        public Funcionario BuscarPorId(int? id)
        {
            return _context.Funcionarios.Find(id);

        }
        // C = Objeto 
        public void RemoverFuncionario(int? id)
        {
            _context.Funcionarios.Remove(BuscarPorId(id));
            _context.SaveChanges();
        }
        public void AlterarFuncionario(Funcionario f)
        {
            _context.Funcionarios.Update(f);
            _context.SaveChanges();
        }
    }
}
