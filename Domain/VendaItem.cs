using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    [Table("VendasItem")]
    public class VendaItem
    {
        public VendaItem()
        {
            Criadoem = DateTime.Now;
            Produtos = new Produto();
        }
        [Key]
        public int Id { get; set; }
        public Produto Produtos { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public DateTime Criadoem { get; set; }

        public override string ToString()
        {
            return this.Produtos.Nome;
        }
    }
}
