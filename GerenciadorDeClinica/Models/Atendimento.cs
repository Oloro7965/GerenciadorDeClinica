using GerenciadorDeClinica.Models.Enums;

namespace GerenciadorDeClinica.Models
{
    public class Atendimento:BaseEntity
    {
        public Guid IdPaciente { get;  set; }
        public Guid IdServico { get; set; }
        public Guid IdMedico { get; set; }
        public string Convenio { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public ETipoAtendimento TipoAtendimento { get; set; }

        public Atendimento(Guid idPaciente, Guid idServico, Guid idMedico, string convenio, DateTime inicio, DateTime fim, ETipoAtendimento tipoAtendimento)
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
