using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    [Table("Produtos")]
    public class Produto
    {
        public Produto() { criadoEm = DateTime.Now; }
        [Key]
        public int ProdutoId { get; set; }
        [Display(Name = "Nome do produto:")]
        [Required(ErrorMessage = "Campo Obrigatorio")]
        [MinLength(5, ErrorMessage = "No mínimo 5 caracteres!")]
        [MaxLength(40, ErrorMessage = "No máximo 40 caracteres!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo Obrigatorio")]
        [Display(Name = "Preço do produto:")]
        public double? Preco { get; set; }
        [Required(ErrorMessage = "Campo Obrigatorio")]
        [Display(Name = "Quantidade do produto:")]
        [Range(1, 1000, ErrorMessage = "Os valores devem estar entre 1 e 1000")]
        public int Quantidade { get; set; }
        [Display(Name = "Categoria do produto:")]
        public Categoria Categoria { get; set; }
        public DateTime criadoEm { get; set; }

    }
}
