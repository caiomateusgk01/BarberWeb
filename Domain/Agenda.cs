using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    [Table("Agenda")]
    public class Agenda
    {
        public Agenda()
        {
            Data = DateTime.Now;
            Cliente = new Cliente();
            Funcionario = new Funcionario();
        }
        [Key]
        public int Id { get; set; }
        [Display(Name = "Hora Inicial")]
        [Required(ErrorMessage = "Campo Obrigatorio")]
        public string HrInicial { get; set; }
        public Cliente Cliente { get; set; }
        public Funcionario Funcionario { get; set; }
        public DateTime Data { get; set; }

        public override string ToString()
        {
            return "Hora Inicial: " + HrInicial +
                " | Horário Atual: " + Data +
                "Funcionario: " + Funcionario.Id + "| Cliente " + Cliente.Id;
        }
    }
}
