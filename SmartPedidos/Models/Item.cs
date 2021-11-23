namespace SmartPedidos.Models
{
    public class Item 
    {
        public Item(){}

        public Item(int id, int codigoPedido, string descricao, double valorItem) 
        {
            this.Id = id;
            this.CodigoPedido = codigoPedido;
            this.Descricao = descricao;
            this.ValorItem = valorItem;
               
        }
        public int Id { get; set; }
        public int CodigoPedido { get; set; }
        public string Descricao { get; set; }
        public double ValorItem { get; set; }
    }
}