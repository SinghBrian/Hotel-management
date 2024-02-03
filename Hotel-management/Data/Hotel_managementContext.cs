using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Hotel_management.Models;

namespace Hotel_management.Data
{
    public class Hotel_managementContext : DbContext
    {
        public Hotel_managementContext (DbContextOptions<Hotel_managementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Hotel_management.Models.Client> Client { get; set; }
        public virtual DbSet<Hotel_management.Models.Hotels> Hotels { get; set; }
        public virtual DbSet<Hotel_management.Models.Chambre> Chambre { get; set; }
        public virtual DbSet<Hotel_management.Models.Commentaire> Commentaire { get; set; }
        public virtual DbSet<Hotel_management.Models.Statut>? Statuts { get; set; } = default!;
        public virtual DbSet<Hotel_management.Models.Saison> Saisons { get; set; } = default!;
        public virtual DbSet<Hotel_management.Models.Tarifs>? Tarifss { get; set; } = default!;
        public virtual DbSet<Hotel_management.Models.Categorie>? Categories { get; set; } = default!;
        public virtual DbSet<Hotel_management.Models.Facture> Facture { get; set; } = default!;
        public virtual DbSet<Hotel_management.Models.Reservation> Reservation { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Concerner>()
                  .HasKey(m => new { m.ReservationId, m.ChamberId });
        }
    }
}
