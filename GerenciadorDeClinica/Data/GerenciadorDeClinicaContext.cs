using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GerenciadorDeClinica.Models;

namespace GerenciadorDeClinica.Data
{
    public class GerenciadorDeClinicaContext : DbContext
    {
        public GerenciadorDeClinicaContext (DbContextOptions<GerenciadorDeClinicaContext> options)
            : base(options)
        {
        }

        public DbSet<GerenciadorDeClinica.Models.Medico> Medico { get; set; } = default!;
        public DbSet<GerenciadorDeClinica.Models.Paciente> Paciente { get; set; } = default!;
        public DbSet<GerenciadorDeClinica.Models.Atendimento> Atendimento { get; set; } = default!;
        public DbSet<GerenciadorDeClinica.Models.Servico> Servico { get; set; } = default!;
    }
}
