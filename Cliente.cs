namespace Aula20ExercicioDeFixação
{
    public class Cliente
    {
        public string Nome;
        public string EnderecoAtual;

        public string MostrarDados(){
            return $"Nome: {Nome}, EnderecoAtual{EnderecoAtual}";
        }
    }
}