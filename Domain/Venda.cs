﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    [Table("Vendas")]
     public class Venda
    {
        public Venda()
        {
            Criadoem = DateTime.Now;
            //VendasItem = new List<VendaItem>();
        }
        [Key]
        public int Id { get; set; }

        public int? ClienteId { get; set; }
        [ForeignKey("ClienteId")]
        public virtual Cliente idCliente { get; set; }
        public int? FuncionarioId { get; set; }

        [ForeignKey("FuncionarioId")]
        public virtual Funcionario idFuncionario { get; set; }
        public virtual Produto Produtos { get; set; }
        public virtual List<VendaItem> VendasItem { get; set; }
        public DateTime Criadoem { get; set; }


    }
}
