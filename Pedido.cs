namespace Aula20ExercicioDeFixação
{
    public class Pedido
    {
        public Pedido(string itens, string cliente, string restaurante, string formaDePGTO)
        {
            this.Itens = itens;
            this.Cliente = cliente;
            this.Restaurante = restaurante;
            this.FormaDePGTO = formaDePGTO;

        
        }
        public string Itens { get; set; }
        public string Cliente { get; set; }
        public string Restaurante { get; set; }
        public string FormaDePGTO { get; set; }
       

        public bool pedidoPago;



        public void EntregarPedido()
        {
            System.Console.WriteLine($"Pedido entregue");
        }

    }
}