using System.ComponentModel;

namespace GerenciadorDeClinica.Models.Enums
{
    public enum ETipoSanguíneo
    {
        [Description("A+")] APositivo,
        [Description("A-")] ANegativo,
        [Description("B+")] BPositivo,
        [Description("B-")] BNegativo,
        [Description("AB+")] ABPositivo,
        [Description("AB-")] ABNegativo,
        [Description("O+")] OPositivo,
        [Description("O-")] ONegativo
    }
}
