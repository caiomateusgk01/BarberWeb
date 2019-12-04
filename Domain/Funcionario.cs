using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    [Table("Funcionarios")]
    public class Funcionario
    {
        public Funcionario()
        {
            CriadoEm = DateTime.Now;
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
        public DateTime CriadoEm { get; set; }
        public List<Cliente> Clientes { get; set; }
        public List<Agenda> Agenda { get; set; }


        public override string ToString()
        {
            return "Nome: " + Nome + "  | CPF: " + Cpf + " | RG: " + Rg + "  | Telefone: " + Telefone + " | Horário Atual: " + CriadoEm +
                "| E-mail: " + Email + "| Endereco " + Endereco;
        }

    }
}
