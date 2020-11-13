using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaAPI3B1.Models
{
    // Model == DTO
    public class ProdutoModel
    {
        private int id, tbl_categoria_id, quantidade;
        private String nomeProduto, descricao, foto;
        private Double preco, peso;

        public ProdutoModel(int id, int tbl_categoria_id, int quantidade, string nomeProduto, string descricao, string foto, double preco, double peso)
        {
            this.id = id;
            this.tbl_categoria_id = tbl_categoria_id;
            this.quantidade = quantidade;
            this.nomeProduto = nomeProduto;
            this.descricao = descricao;
            this.foto = foto;
            this.preco = preco;
            this.peso = peso;
        }

        public int Id { get => id; set => id = value; }
        public int Tbl_categoria_id { get => tbl_categoria_id; set => tbl_categoria_id = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public string NomeProduto { get => nomeProduto; set => nomeProduto = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Foto { get => foto; set => foto = value; }
        public double Preco { get => preco; set => preco = value; }
        public double Peso { get => peso; set => peso = value; }
    }
}