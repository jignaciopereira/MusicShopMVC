using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MusicShopMVC.Models;

namespace MusicShopMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Bajo> Bajos { get; set; }
        public DbSet<Bateria> Baterias { get; set; }
        public DbSet<Flauta> Flautas { get; set; }
        public DbSet<GuitarraAcustica> GuitarrasAcusticas { get; set; }
        public DbSet<GuitarraCriolla> GuitarrasCriollas { get; set; }
        public DbSet<GuitarraElectrica> GuitarrasElectricas { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<PianoDigital> PianosDigitales { get; set; }
        public DbSet<Saxofon> Saxofones { get; set; }
        public DbSet<Teclado> Teclados { get; set; }
        public DbSet<Trompeta> Trompetas { get; set; }
        public DbSet<Violin> Violines { get; set; }
        public DbSet<InstrumentoCuerda> InstrumentosDeCuerda { get; set; }
        public DbSet<InstrumentoTecla> InstrumentosDeTecla { get; set; }
        public DbSet<InstrumentoViento> InstrumentosDeViento { get; set; }
        public DbSet<InstrumentoPercusion> InstrumentosDePercusion { get; set; }
    }
}
