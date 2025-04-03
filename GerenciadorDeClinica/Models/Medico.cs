using GerenciadorDeClinica.Models.Enums;

namespace GerenciadorDeClinica.Models
{
    public class Medico:BaseEntity
    {
        public Medico(string nome, string sobrenome, DateTime dataNascimento, string telefone, string email, string cpf, string endereco, ETipoSanguineo tipoSanguineo, string cRM, EEspecialidade especialidade)
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
        public Medico() { }

        public string Nome { get;  set; }
        public string Sobrenome { get;  set; }
        public DateTime DataNascimento { get;  set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public string Cpf { get; set; }
        public string endereco { get; set; }
        public ETipoSanguineo tipoSanguineo { get;set; }
        public string CRM { get; set; }
        public EEspecialidade especialidade { get; set; }
    }
}
