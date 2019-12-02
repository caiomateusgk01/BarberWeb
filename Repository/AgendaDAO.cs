using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
   public class AgendaDAO : IRepository<Agenda>
    {
        private readonly Context _context;
        public AgendaDAO(Context context)
        {

            _context = context;
        }

        public List<Agenda> ListarTodos() => _context.Agendas.Include("Cliente").Include("Funcionario").ToList();


        public bool Cadastrar(Agenda a)
        {
            if (BuscarAgendamentoDataFuncionario(a) == null)
            {
                _context.Agendas.Add(a);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public Agenda BuscarCFPorId(Agenda a)
        {
            return _context.Agendas.FirstOrDefault
                (x => x.Cliente.Id.Equals(a.Cliente.Id) &&
                 x.Funcionario.Id.Equals(a.Funcionario.Id));

        }
        public Agenda BuscarPorId(int? cli)
        {
            return _context.Agendas.Find(cli);
        }

        public Agenda BuscarAgendamentoDataFuncionario(Agenda a)
        {
            return _context.Agendas.FirstOrDefault
              (x => x.Data.Day == a.Data.Day &&
              x.Data.Month == a.Data.Month &&
              x.Data.Year == a.Data.Year &&
              x.HrInicial.Equals(a.HrInicial) &&
              x.Funcionario.Nome.Equals(a.Funcionario.Nome));
        }
        public Agenda BuscarNome(Agenda a)
        {
            return _context.Agendas.FirstOrDefault
                (x => x.Cliente.Nome.Equals(a.Cliente.Nome) &&
                x.Funcionario.Nome.Equals(a.Funcionario.Nome));
        }
        public void EditarAgenda(Agenda a)
        {
            _context.Agendas.Update(a);
            _context.SaveChanges();
        }

        public void Remover(int? a)
        {
            _context.Agendas.Remove(BuscarPorId(a));
            _context.SaveChanges();
        }
    }
}
