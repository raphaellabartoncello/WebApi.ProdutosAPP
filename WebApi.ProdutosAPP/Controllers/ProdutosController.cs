using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.ProdutosAPP.Models;

namespace WebApi.ProdutosAPP.Controllers
{
    public class ProdutosController : ApiController
    {
        //Criar um array de produtos para testar a api
        Produto[] produtos = new Produto[]
        {
            new Produto{ID=1, Nome="Camiseta HB20", Categoria="Vestuario", Preco=80m},
            new Produto{ID=2, Nome="Pizza Mussarela", Categoria="Alimentacao", Preco=49.9m},

        };

        //Criar os métodos da nossa WebAPI em REST
        public IEnumerable<Produto> GetAllProduto()
        {
            return produtos;
        }

        public IHttpActionResult GetProduto(int id)
        {
            //Ler o array de produto
            //Utilizar o LINQ para filtrar o produto por ID
            var produto = produtos.FirstOrDefault((x) => x.ID == id);

            if (produto == null)
            {
                //Se o produto for nulo, não existe - devolver not found
                return NotFound();
            }

            return Ok(produto);
        }
    };
}
