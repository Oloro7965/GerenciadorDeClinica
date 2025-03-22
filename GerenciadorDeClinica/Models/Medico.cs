using GerenciadorDeClinica.Models.Enums;

namespace GerenciadorDeClinica.Models
{
    public class Medico:BaseEntity
    {
        public Medico(string nome, string sobrenome, DateTime dataNascimento, string telefone, string email, string cpf, string endereco, ETipoSanguíneo tipoSanguineo, string cRM, EEspecialidade especialidade)
        {
            
            Nome = nome;
            Sobrenome = sobrenome;
            DataNascimento = dataNascimento;
            this.telefone = telefone;
            this.email = email;
            Cpf = cpf;
            this.endereco = endereco;
            this.tipoSanguineo = tipoSanguineo;
            CRM = cRM;
            this.especialidade = especialidade;
        }

 
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public string telefone { get; private set; }
        public string email { get; private set; }
        public string Cpf { get; private set; }
        public string endereco { get; private set; }
        public ETipoSanguíneo tipoSanguineo { get;private set; }
        public string CRM { get; private set; }
        public EEspecialidade especialidade { get; private set; }
    }
}
