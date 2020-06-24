using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.ProdutosAPP.Models
{
    public class Produto
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public decimal Preco { get; set; }

    }
}