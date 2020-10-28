using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaAPI3B1.Models
{
    public class ClienteModel
    {

        private int id_cliente;
        private string nom_cliente;
        private string sobrenome_cliente;
        private string email_cliente;

        public ClienteModel()
        {

        }

        public ClienteModel(int id_cliente, string nom_cliente, string sobrenome_cliente, string email_cliente)
        {
            this.id_cliente = id_cliente;
            this.nom_cliente = nom_cliente;
            this.sobrenome_cliente = sobrenome_cliente;
            this.email_cliente = email_cliente;
        }

        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public string Nom_cliente { get => nom_cliente; set => nom_cliente = value; }
        public string Sobrenome_cliente { get => sobrenome_cliente; set => sobrenome_cliente = value; }
        public string Email_cliente { get => email_cliente; set => email_cliente = value; }
    }
}