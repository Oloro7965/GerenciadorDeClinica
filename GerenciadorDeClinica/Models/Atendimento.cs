using GerenciadorDeClinica.Models.Enums;

namespace GerenciadorDeClinica.Models
{
    public class Atendimento:BaseEntity
    {
        public Guid IdPaciente { get; private set; }
        public Guid IdServico { get; private set; }
        public Guid IdMedico { get; private set; }
        public string Convenio { get; private set; }
        public DateTime Inicio { get; private set; }
        public DateTime Fim { get; private set; }
        public ETipoAtendimento TipoAtendimento { get; private set; }

        public Atendimento(Guid idPaciente, Guid idServico, Guid idMedico, string convenio, DateTime inicio, DateTime fim, TipoAtendimento tipoAtendimento)
        {
            
            IdPaciente = idPaciente;
            IdServico = idServico;
            IdMedico = idMedico;
            Convenio = convenio;
            Inicio = inicio;
            Fim = fim;
            TipoAtendimento = tipoAtendimento;
        }
    }
}
