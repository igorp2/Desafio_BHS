using System;
using System.Globalization;
namespace SmartPedidos.Models
{
    public class Pedido
    {
        public Pedido() {}
        public Pedido(int id, string descricao, DateTime dataPedido, double valorPedido, string status) 
        {
            this.Id = id;
            this.Descricao = descricao;
            this.DataPedido = dataPedido;
            this.ValorPedido = valorPedido;
            this.Status = status;
               
        }
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataPedido { get; set; }
        public double ValorPedido { get; set; }
        public string Status { get; set; }
    }
}