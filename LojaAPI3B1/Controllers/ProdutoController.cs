using LojaAPI3B1.DAL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LojaAPI3B1.Controllers
{
    [RoutePrefix("api/produto")]
    public class ProdutoController : ApiController
    {
        private DALMysql daoBanco = new DALMysql();

        [AcceptVerbs("GET")]
        [Route("listarProdutoPorCodigo/{id_produto}")]
        public string listarProdutoPorCodigo(int id_produto)
        {
            string sql = string.Format($@"select id, nomeProduto, descricao, preco, quantidade, peso, tbl_categoria_id, foto from tbl_produto where id = " + id_produto);
            string jsonString = string.Empty;
            jsonString = JsonConvert.SerializeObject(daoBanco.executarConsulta(sql));
            return jsonString;
        }

        [AcceptVerbs("GET")]
        [Route("listarProdutoPorCat/{id_categoria}")]
        public string listarProdutoPorCat(int id_categoria)
        {
            string sql = string.Format($@"select id, nomeProduto, descricao, preco, quantidade, peso, tbl_categoria_id, foto from tbl_produto where tbl_categoria_id = " + id_categoria);
            string jsonString = string.Empty;
            jsonString = JsonConvert.SerializeObject(daoBanco.executarConsulta(sql));
            return jsonString;
        }


    }

}
