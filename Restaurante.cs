namespace Aula20ExercicioDeFixação
{
    public class Restaurante
    {
        public string NomeFantasia;
        public string Endereco;
        private string v;

        public Restaurante(string v)
        {
            this.v = v;
        }

        public string MostrarDados(){
            return $"NomeFantasia: {NomeFantasia}, Endereco: {Endereco}";

        }
    }
}