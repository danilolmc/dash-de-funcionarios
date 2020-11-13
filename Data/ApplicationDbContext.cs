using System;
using System.Collections.Generic;
using System.Text;
using desafio_mvc.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace desafio_mvc.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {


        public DbSet<Vaga> Vagas { get; set; }
        public DbSet<Gft> Gft { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Tecnologia> Tecnologias { get; set; }
        public DbSet<Funcionario_Tecnologia> Funcionario_Tecnologias { get; set; }
        public DbSet<Vaga_tecnologia> Vaga_Tecnologias { get; set; }
        public DbSet<Alocacao> Alocacoes { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // FLuent API
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Funcionario_Tecnologia>()
               .HasKey(fc => new { fc.Id });

            builder.Entity<Funcionario_Tecnologia>()
                .HasOne(fc => fc.Funcionario)
                .WithMany(fc => fc.FuncionarioTecnologias)
                .HasForeignKey(fc => fc.Funcionario_Id);

            builder.Entity<Funcionario_Tecnologia>()
                .HasOne(fc => fc.Tecnologia)
                .WithMany(fc => fc.FuncionarioTecnologias)
                .HasForeignKey(fc => fc.Tecnologia_Id);

            builder.Entity<Vaga_tecnologia>()
               .HasKey(vt => new { vt.Id });

            builder.Entity<Vaga_tecnologia>()
                .HasOne(vt => vt.Vaga)
                .WithMany(vt => vt.VagaTecnologias)
                .HasForeignKey(vt => vt.Vaga_Id);

            builder.Entity<Vaga_tecnologia>()
                .HasOne(vt => vt.Tecnologia)
                .WithMany(vt => vt.VagaTecnologias)
                .HasForeignKey(vt => vt.Tecnologia_Id);
        }
    }
}
