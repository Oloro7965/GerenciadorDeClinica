using GerenciadorDeClinica.Models.Enums;

namespace GerenciadorDeClinica.Models
{
    public class Paciente:BaseEntity
    {
        public Paciente(string nome, string sobrenome, DateTime dataNascimento, string telefone, string email, string cPF, ETipoSanguíneo tipoSanguineo, string endereco, double altura, double peso)
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

        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public string Telefone { get; private set; }
        public string Email { get; private set; }
        public string CPF { get; private set; }
        public ETipoSanguíneo TipoSanguineo { get; private set; }
        public string Endereco { get; private set; }
        public double Altura { get; private set; }
        public double Peso { get; private set; }
    }
}
