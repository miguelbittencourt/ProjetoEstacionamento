using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Estacionamento.Entidades;


namespace Estacionamento
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
        
        public DbSet<Usuarios> USUARIOS { get; set; }
        public DbSet<Veiculos> VEICULOS { get; set; }
        public DbSet<Vagas> VAGAS { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //    optionsBuilder.UseMySQL("Server=localhost;Database=BancoEstacionamento;Uid=root;Pwd=1234;SslMode=none");
        //}
    }
}
