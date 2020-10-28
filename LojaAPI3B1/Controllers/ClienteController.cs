using LojaAPI3B1.Models;
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
        // Lista Provisória para Armazenar os clientes
        private static List<ClienteModel> listaClientes = new List<ClienteModel>();

        // Metodo responsavel pelo Post no Cliente
        [AcceptVerbs("POST")]
        [Route("CadastrarCliente")]
        public string CadastrarCliente(ClienteModel cliente)
        {
            // comando para insert no banco
            listaClientes.Add(cliente);
            return "Cliente Cadastrado com Sucesso";

        }

        // Metodo para Listar todos os cliente
        [AcceptVerbs("GET")]
        [Route("ConsultarCliente")]
        public List<ClienteModel> ConsultarClientes()
        {
            return listaClientes;
        }
    }
}
