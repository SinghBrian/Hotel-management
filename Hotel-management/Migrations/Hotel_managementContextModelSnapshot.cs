﻿// <auto-generated />
using System;
using Hotel_management.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hotel_management.Migrations
{
    [DbContext(typeof(Hotel_managementContext))]
    partial class Hotel_managementContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Hotel_management.Models.Categorie", b =>
                {
                    b.Property<int>("CategoriesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoriesId"), 1L, 1);

                    b.Property<int>("MaxPersonne")
                        .HasColumnType("int");

                    b.Property<string>("libelle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoriesId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Hotel_management.Models.Chambre", b =>
                {
                    b.Property<int>("ChambreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ChambreId"), 1L, 1);

                    b.Property<int?>("CategoriesId")
                        .HasColumnType("int");

                    b.Property<int?>("HotelsId")
                        .HasColumnType("int");

                    b.HasKey("ChambreId");

                    b.HasIndex("CategoriesId");

                    b.HasIndex("HotelsId");

                    b.ToTable("Chambre");
                });

            modelBuilder.Entity("Hotel_management.Models.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClientId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelephoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClientId");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("Hotel_management.Models.Commentaire", b =>
                {
                    b.Property<int>("CommentaireId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CommentaireId"), 1L, 1);

                    b.Property<int?>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("ClientName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CommentaireTexte")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("HotelsId")
                        .HasColumnType("int");

                    b.HasKey("CommentaireId");

                    b.HasIndex("ClientId");

                    b.HasIndex("HotelsId");

                    b.ToTable("Commentaire");
                });

            modelBuilder.Entity("Hotel_management.Models.Concerner", b =>
                {
                    b.Property<int>("ReservationId")
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    b.Property<int>("ChamberId")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<int>("ChambresChambreId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateDeparture")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateErrival")
                        .HasColumnType("datetime2");

                    b.Property<int>("NbAdultes")
                        .HasColumnType("int");

                    b.Property<int>("NbEnfant")
                        .HasColumnType("int");

                    b.HasKey("ReservationId", "ChamberId");

                    b.HasIndex("ChambresChambreId");

                    b.ToTable("Concerner");
                });

            modelBuilder.Entity("Hotel_management.Models.Facture", b =>
                {
                    b.Property<int>("FactureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FactureId"), 1L, 1);

                    b.Property<float>("MontantFacture")
                        .HasColumnType("real");

                    b.Property<int?>("ReservationId")
                        .HasColumnType("int");

                    b.Property<int?>("StatutId")
                        .HasColumnType("int");

                    b.HasKey("FactureId");

                    b.HasIndex("ReservationId");

                    b.HasIndex("StatutId");

                    b.ToTable("Facture");
                });

            modelBuilder.Entity("Hotel_management.Models.Hotels", b =>
                {
                    b.Property<int>("HotelsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HotelsId"), 1L, 1);

                    b.Property<int>("Capacity_Max")
                        .HasColumnType("int");

                    b.Property<string>("Criteria_size")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Criteria_stars")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("destination")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HotelsId");

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("Hotel_management.Models.Reservation", b =>
                {
                    b.Property<int>("ReservationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReservationId"), 1L, 1);

                    b.Property<int?>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("ClientName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReservationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Total")
                        .HasColumnType("int");

                    b.HasKey("ReservationId");

                    b.HasIndex("ClientId");

                    b.ToTable("Reservation");
                });

            modelBuilder.Entity("Hotel_management.Models.Saison", b =>
                {
                    b.Property<int>("SaisonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SaisonId"), 1L, 1);

                    b.Property<DateTime>("DateDebut")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateFin")
                        .HasColumnType("datetime2");

                    b.Property<string>("Libelle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TarifsId")
                        .HasColumnType("int");

                    b.HasKey("SaisonId");

                    b.HasIndex("TarifsId");

                    b.ToTable("Saisons");
                });

            modelBuilder.Entity("Hotel_management.Models.Services_Supplementaire", b =>
                {
                    b.Property<int>("ServicesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServicesId"), 1L, 1);

                    b.Property<int?>("HotelsId")
                        .HasColumnType("int");

                    b.Property<float>("ServciesPrix")
                        .HasColumnType("real");

                    b.Property<string>("ServicesName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ServicesId");

                    b.HasIndex("HotelsId");

                    b.ToTable("Services_Supplementaire");
                });

            modelBuilder.Entity("Hotel_management.Models.Statut", b =>
                {
                    b.Property<int>("StatutId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StatutId"), 1L, 1);

                    b.Property<string>("Libelle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StatutId");

                    b.ToTable("Statuts");
                });

            modelBuilder.Entity("Hotel_management.Models.Tarifs", b =>
                {
                    b.Property<int>("TarifsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TarifsId"), 1L, 1);

                    b.Property<int?>("CategoriesId")
                        .HasColumnType("int");

                    b.Property<int>("PrixCat")
                        .HasColumnType("int");

                    b.HasKey("TarifsId");

                    b.HasIndex("CategoriesId");

                    b.ToTable("Tarifss");
                });

            modelBuilder.Entity("Hotel_management.Models.Chambre", b =>
                {
                    b.HasOne("Hotel_management.Models.Categorie", null)
                        .WithMany("ChambreCat")
                        .HasForeignKey("CategoriesId");

                    b.HasOne("Hotel_management.Models.Hotels", null)
                        .WithMany("Chambre")
                        .HasForeignKey("HotelsId");
                });

            modelBuilder.Entity("Hotel_management.Models.Commentaire", b =>
                {
                    b.HasOne("Hotel_management.Models.Client", null)
                        .WithMany("Comments")
                        .HasForeignKey("ClientId");

                    b.HasOne("Hotel_management.Models.Hotels", null)
                        .WithMany("Commentaire")
                        .HasForeignKey("HotelsId");
                });

            modelBuilder.Entity("Hotel_management.Models.Concerner", b =>
                {
                    b.HasOne("Hotel_management.Models.Chambre", "Chambres")
                        .WithMany()
                        .HasForeignKey("ChambresChambreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hotel_management.Models.Reservation", "Reservations")
                        .WithMany()
                        .HasForeignKey("ReservationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chambres");

                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("Hotel_management.Models.Facture", b =>
                {
                    b.HasOne("Hotel_management.Models.Reservation", null)
                        .WithMany("Facts")
                        .HasForeignKey("ReservationId");

                    b.HasOne("Hotel_management.Models.Statut", null)
                        .WithMany("factures")
                        .HasForeignKey("StatutId");
                });

            modelBuilder.Entity("Hotel_management.Models.Reservation", b =>
                {
                    b.HasOne("Hotel_management.Models.Client", null)
                        .WithMany("Reservations")
                        .HasForeignKey("ClientId");
                });

            modelBuilder.Entity("Hotel_management.Models.Saison", b =>
                {
                    b.HasOne("Hotel_management.Models.Tarifs", null)
                        .WithMany("Saisons")
                        .HasForeignKey("TarifsId");
                });

            modelBuilder.Entity("Hotel_management.Models.Services_Supplementaire", b =>
                {
                    b.HasOne("Hotel_management.Models.Hotels", null)
                        .WithMany("Services_Supplementaire")
                        .HasForeignKey("HotelsId");
                });

            modelBuilder.Entity("Hotel_management.Models.Tarifs", b =>
                {
                    b.HasOne("Hotel_management.Models.Categorie", null)
                        .WithMany("TarifsCat")
                        .HasForeignKey("CategoriesId");
                });

            modelBuilder.Entity("Hotel_management.Models.Categorie", b =>
                {
                    b.Navigation("ChambreCat");

                    b.Navigation("TarifsCat");
                });

            modelBuilder.Entity("Hotel_management.Models.Client", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("Hotel_management.Models.Hotels", b =>
                {
                    b.Navigation("Chambre");

                    b.Navigation("Commentaire");

                    b.Navigation("Services_Supplementaire");
                });

            modelBuilder.Entity("Hotel_management.Models.Reservation", b =>
                {
                    b.Navigation("Facts");
                });

            modelBuilder.Entity("Hotel_management.Models.Statut", b =>
                {
                    b.Navigation("factures");
                });

            modelBuilder.Entity("Hotel_management.Models.Tarifs", b =>
                {
                    b.Navigation("Saisons");
                });
#pragma warning restore 612, 618
        }
    }
}
