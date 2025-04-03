using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciadorDeClinica.Models
{
    public class Servico:BaseEntity
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Valor { get;  set; }
        public int Duracao { get; set; } // em minutos

        public Servico( string nome, string descricao, decimal valor, int duracao)
        {
            
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
            Duracao = duracao;
        }
    }
}
