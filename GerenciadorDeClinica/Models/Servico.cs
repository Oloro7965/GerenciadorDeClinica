namespace GerenciadorDeClinica.Models
{
    public class Servico:BaseEntity
    {
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public decimal Valor { get; private set; }
        public int Duracao { get; private set; } // em minutos

        public Servico( string nome, string descricao, decimal valor, int duracao)
        {
            
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
            Duracao = duracao;
        }
    }
}
