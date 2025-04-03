using GerenciadorDeClinica.Models.Enums;

namespace GerenciadorDeClinica.Models
{
    public class Paciente:BaseEntity
    {
        public Paciente(string nome, string sobrenome, DateTime dataNascimento, string telefone, string email, string cPF, ETipoSanguineo tipoSanguineo, string endereco, double altura, double peso)
        {
            
            Nome = nome;
            Sobrenome = sobrenome;
            DataNascimento = dataNascimento;
            Telefone = telefone;
            Email = email;
            CPF = cPF;
            TipoSanguineo = tipoSanguineo;
            Endereco = endereco;
            Altura = altura;
            Peso = peso;
        }

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Email { get;  set; }
        public string CPF { get; set; }
        public ETipoSanguineo TipoSanguineo { get; set; }
        public string Endereco { get;  set; }
        public double Altura { get; set; }
        public double Peso { get; set; }
    }
}
