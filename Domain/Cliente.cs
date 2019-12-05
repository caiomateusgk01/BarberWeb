using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    [Table("Clientes")]
    public class Cliente
    {


        public Cliente()
        {
            Criadoem = DateTime.Now;

        }
        [Key]
        public int Id { get; set; }
        [Display(Name = "Nome do Cliente")]
        [Required(ErrorMessage = "Campo Obrigatorio")]
        [MinLength(5, ErrorMessage = "No mínimo 5 caracteres!")]
        [MaxLength(40, ErrorMessage = "No máximo 60 caracteres!")]
        public string Nome { get; set; }
        [Display(Name = "RG")]
        [Required(ErrorMessage = "Campo Obrigatorio")]
        public string Rg { get; set; }
        [Display(Name = "CPF")]
        [Required(ErrorMessage = "Campo Obrigatorio")]
        public string Cpf { get; set; }
        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "Campo Obrigatorio")]
        public string Telefone { get; set; }
        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "Campo Obrigatorio")]
        [MinLength(5, ErrorMessage = "No mínimo 5 caracteres!")]
        [MaxLength(40, ErrorMessage = "No máximo 100 caracteres!")]
        public string Email { get; set; }
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }
        [Display(Name = "Horário Atual")]
        public DateTime Criadoem { get; set; }
        public Funcionario Funcionario { get; set; }
        public List<Agenda> Agenda { get; set; }
        public override string ToString()
        {
            return "Nome: " + Nome + " | CPF: " + Cpf + " | Telefone: " + Telefone + " | Horário Atual: " + Criadoem +
                "| E-mail: " + Email + "| Endereco " + Endereco + "| Funcionario " + Funcionario;
        }

    }
}
