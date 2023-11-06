using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace SmartShop.Models
{
    public partial class ModelDbContext : DbContext
    {
        public ModelDbContext()
            : base("name=ModelDbContext")
        {
        }

        public virtual DbSet<Carrello> Carrello { get; set; }
        public virtual DbSet<Categorie> Categorie { get; set; }
        public virtual DbSet<Dettagli> Dettagli { get; set; }
        public virtual DbSet<Ordini> Ordini { get; set; }
        public virtual DbSet<Prodotti> Prodotti { get; set; }
        public virtual DbSet<Recensioni> Recensioni { get; set; }
        public virtual DbSet<Spedizioni> Spedizioni { get; set; }
        public virtual DbSet<Utente> Utente { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dettagli>()
                .Property(e => e.PrezzoUnitario)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Ordini>()
                .Property(e => e.Totale)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Ordini>()
                .HasMany(e => e.Dettagli)
                .WithRequired(e => e.Ordini)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Prodotti>()
                .Property(e => e.Prezzo)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Utente>()
                .HasMany(e => e.Carrello)
                .WithRequired(e => e.Utente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Utente>()
                .HasMany(e => e.Ordini)
                .WithRequired(e => e.Utente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Utente>()
                .HasMany(e => e.Spedizioni)
                .WithRequired(e => e.Utente)
                .WillCascadeOnDelete(false);
        }
    }
}
