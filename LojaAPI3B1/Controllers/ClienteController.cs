using LojaAPI3B1.DAL;
using LojaAPI3B1.Models;
using ProjetoLogin3D2.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LojaAPI3B1.Controllers
{
    
    // Definição do Endpoint
    [RoutePrefix("api/cliente")]
    public class ClienteController : ApiController
    {
        // Instanciar a BLL para tratamento de dados no Mysql
        tblClienteBLL bllcliente = new tblClienteBLL();
        private DALMysql daoBanco = new DALMysql();

        // Lista Provisória para Armazenar os clientes
        private static List<ClienteModel> listaClientes = new List<ClienteModel>();

        // Metodo responsavel pelo Post no Cliente
      
        [AcceptVerbs("POST")]
        [Route("CadastrarCliente")]
        public string CadastrarCliente(ClienteModel cliente)
        {
            // Comando para Inserir no Array
            listaClientes.Add(cliente);
            // comando para insert no banco
            bllcliente.InserirCliente(cliente);
            return "Cliente Cadastrado com Sucesso";

        }

        // Metodo para Listar todos os cliente
        [AcceptVerbs("GET")]
        [Route("listarClientes")]
        public List<ClienteModel> listarClientes()
        {
            return listaClientes;
        }

        // Metodo para Listar o Cliente pelo Código
        [AcceptVerbs("GET")]
        [Route("listarClientesPorCodigo/{id_cliente}")]
        public ClienteModel listarClientesPorCodigo(int id_cliente)
        {
            ClienteModel cliente = listaClientes.Where(n => n.Id_cliente == id_cliente)
                                                       .Select(n => n)
                                                       .FirstOrDefault();
            // Lista cliente no Banco de Dados pelo código
            string sql = string.Format($@"select id_cliente, nome_cliente sobrenome_cliente, email_cliente from tbl_cliente where " + id_cliente);
            
           // ClienteModel retornobanco = daoBanco.executarConsulta(sql);

            return cliente;
        }

        // Metodo para deletar cliente
        [AcceptVerbs("DELETE")]
        [Route("excluirCliente/{id_cliente}")]
        public string excluirCliente(int id_cliente)
        {
            // Exclusão no ArryaList
            //  ClienteModel cliente = listaClientes.Where(n => n.Id_cliente == id_cliente)
            //                                           .Select(n => n)
            //                                           .First();
            //listaClientes.Remove(cliente);

            // Exclusao no Banco Mysql
            bllcliente.ExcluirCliente(id_cliente);


            return "Registro Excluido com sucesso";
        }
        // Metodo para Alterar o Cliente
        [AcceptVerbs("PUT")]
        [Route("alterarCliente")]
        public string alterarCliente(ClienteModel cliente)
        {
            bllcliente.AlterarCliente(cliente);
            return "Cliente Alterado com sucesso";
        }


    }
}
