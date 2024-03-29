USE [master]
GO
/****** Object:  Database [Hotel_management.Data]    Script Date: 10-02-24 19:52:14 ******/
CREATE DATABASE [Hotel_management.Data]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Hotel_management.Data', FILENAME = N'C:\Users\harji\Hotel_management.Data.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Hotel_management.Data_log', FILENAME = N'C:\Users\harji\Hotel_management.Data_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Hotel_management.Data] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Hotel_management.Data].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Hotel_management.Data] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Hotel_management.Data] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Hotel_management.Data] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Hotel_management.Data] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Hotel_management.Data] SET ARITHABORT OFF 
GO
ALTER DATABASE [Hotel_management.Data] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Hotel_management.Data] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Hotel_management.Data] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Hotel_management.Data] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Hotel_management.Data] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Hotel_management.Data] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Hotel_management.Data] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Hotel_management.Data] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Hotel_management.Data] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Hotel_management.Data] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Hotel_management.Data] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Hotel_management.Data] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Hotel_management.Data] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Hotel_management.Data] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Hotel_management.Data] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Hotel_management.Data] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [Hotel_management.Data] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Hotel_management.Data] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Hotel_management.Data] SET  MULTI_USER 
GO
ALTER DATABASE [Hotel_management.Data] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Hotel_management.Data] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Hotel_management.Data] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Hotel_management.Data] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Hotel_management.Data] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Hotel_management.Data] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Hotel_management.Data] SET QUERY_STORE = OFF
GO
USE [Hotel_management.Data]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 10-02-24 19:52:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 10-02-24 19:52:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoriesId] [int] IDENTITY(1,1) NOT NULL,
	[libelle] [nvarchar](max) NOT NULL,
	[MaxPersonne] [int] NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoriesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Chambre]    Script Date: 10-02-24 19:52:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chambre](
	[ChambreId] [int] IDENTITY(1,1) NOT NULL,
	[HotelsId] [int] NULL,
	[CategoriesId] [int] NULL,
 CONSTRAINT [PK_Chambre] PRIMARY KEY CLUSTERED 
(
	[ChambreId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 10-02-24 19:52:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[ClientId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[TelephoneNumber] [nvarchar](max) NOT NULL,
	[email] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[ClientId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Commentaire]    Script Date: 10-02-24 19:52:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Commentaire](
	[CommentaireId] [int] IDENTITY(1,1) NOT NULL,
	[CommentaireTexte] [nvarchar](max) NOT NULL,
	[ClientId] [int] NULL,
	[HotelsId] [int] NULL,
	[ClientName] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Commentaire] PRIMARY KEY CLUSTERED 
(
	[CommentaireId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Concerner]    Script Date: 10-02-24 19:52:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Concerner](
	[ReservationId] [int] NOT NULL,
	[ChamberId] [int] NOT NULL,
	[ChambresChambreId] [int] NOT NULL,
	[NbAdultes] [int] NOT NULL,
	[NbEnfant] [int] NOT NULL,
	[DateErrival] [datetime2](7) NOT NULL,
	[DateDeparture] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Concerner] PRIMARY KEY CLUSTERED 
(
	[ReservationId] ASC,
	[ChamberId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Facture]    Script Date: 10-02-24 19:52:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Facture](
	[FactureId] [int] IDENTITY(1,1) NOT NULL,
	[MontantFacture] [real] NOT NULL,
	[ReservationId] [int] NULL,
	[StatutId] [int] NULL,
 CONSTRAINT [PK_Facture] PRIMARY KEY CLUSTERED 
(
	[FactureId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hotels]    Script Date: 10-02-24 19:52:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hotels](
	[HotelsId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[Criteria_stars] [nvarchar](max) NOT NULL,
	[Criteria_size] [nvarchar](max) NOT NULL,
	[Capacity_Max] [int] NOT NULL,
	[destination] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Hotels] PRIMARY KEY CLUSTERED 
(
	[HotelsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reservation]    Script Date: 10-02-24 19:52:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reservation](
	[ReservationId] [int] IDENTITY(1,1) NOT NULL,
	[Total] [int] NOT NULL,
	[ReservationDate] [datetime2](7) NOT NULL,
	[ClientName] [nvarchar](max) NOT NULL,
	[ClientId] [int] NULL,
 CONSTRAINT [PK_Reservation] PRIMARY KEY CLUSTERED 
(
	[ReservationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Saisons]    Script Date: 10-02-24 19:52:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Saisons](
	[SaisonId] [int] IDENTITY(1,1) NOT NULL,
	[DateDebut] [datetime2](7) NOT NULL,
	[DateFin] [datetime2](7) NOT NULL,
	[Libelle] [nvarchar](max) NOT NULL,
	[TarifsId] [int] NULL,
 CONSTRAINT [PK_Saisons] PRIMARY KEY CLUSTERED 
(
	[SaisonId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Services_Supplementaire]    Script Date: 10-02-24 19:52:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Services_Supplementaire](
	[ServicesId] [int] IDENTITY(1,1) NOT NULL,
	[ServicesName] [nvarchar](max) NOT NULL,
	[ServciesPrix] [real] NOT NULL,
	[HotelsId] [int] NULL,
 CONSTRAINT [PK_Services_Supplementaire] PRIMARY KEY CLUSTERED 
(
	[ServicesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Statuts]    Script Date: 10-02-24 19:52:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Statuts](
	[StatutId] [int] IDENTITY(1,1) NOT NULL,
	[Libelle] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Statuts] PRIMARY KEY CLUSTERED 
(
	[StatutId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tarifss]    Script Date: 10-02-24 19:52:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tarifss](
	[TarifsId] [int] IDENTITY(1,1) NOT NULL,
	[PrixCat] [int] NOT NULL,
	[CategoriesId] [int] NULL,
 CONSTRAINT [PK_Tarifss] PRIMARY KEY CLUSTERED 
(
	[TarifsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Index [IX_Chambre_CategoriesId]    Script Date: 10-02-24 19:52:15 ******/
CREATE NONCLUSTERED INDEX [IX_Chambre_CategoriesId] ON [dbo].[Chambre]
(
	[CategoriesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Chambre_HotelsId]    Script Date: 10-02-24 19:52:15 ******/
CREATE NONCLUSTERED INDEX [IX_Chambre_HotelsId] ON [dbo].[Chambre]
(
	[HotelsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Commentaire_ClientId]    Script Date: 10-02-24 19:52:15 ******/
CREATE NONCLUSTERED INDEX [IX_Commentaire_ClientId] ON [dbo].[Commentaire]
(
	[ClientId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Commentaire_HotelsId]    Script Date: 10-02-24 19:52:15 ******/
CREATE NONCLUSTERED INDEX [IX_Commentaire_HotelsId] ON [dbo].[Commentaire]
(
	[HotelsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Concerner_ChambresChambreId]    Script Date: 10-02-24 19:52:15 ******/
CREATE NONCLUSTERED INDEX [IX_Concerner_ChambresChambreId] ON [dbo].[Concerner]
(
	[ChambresChambreId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Facture_ReservationId]    Script Date: 10-02-24 19:52:15 ******/
CREATE NONCLUSTERED INDEX [IX_Facture_ReservationId] ON [dbo].[Facture]
(
	[ReservationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Facture_StatutId]    Script Date: 10-02-24 19:52:15 ******/
CREATE NONCLUSTERED INDEX [IX_Facture_StatutId] ON [dbo].[Facture]
(
	[StatutId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Reservation_ClientId]    Script Date: 10-02-24 19:52:15 ******/
CREATE NONCLUSTERED INDEX [IX_Reservation_ClientId] ON [dbo].[Reservation]
(
	[ClientId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Saisons_TarifsId]    Script Date: 10-02-24 19:52:15 ******/
CREATE NONCLUSTERED INDEX [IX_Saisons_TarifsId] ON [dbo].[Saisons]
(
	[TarifsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Services_Supplementaire_HotelsId]    Script Date: 10-02-24 19:52:15 ******/
CREATE NONCLUSTERED INDEX [IX_Services_Supplementaire_HotelsId] ON [dbo].[Services_Supplementaire]
(
	[HotelsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Tarifss_CategoriesId]    Script Date: 10-02-24 19:52:15 ******/
CREATE NONCLUSTERED INDEX [IX_Tarifss_CategoriesId] ON [dbo].[Tarifss]
(
	[CategoriesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Commentaire] ADD  DEFAULT (N'') FOR [ClientName]
GO
ALTER TABLE [dbo].[Chambre]  WITH CHECK ADD  CONSTRAINT [FK_Chambre_Categories_CategoriesId] FOREIGN KEY([CategoriesId])
REFERENCES [dbo].[Categories] ([CategoriesId])
GO
ALTER TABLE [dbo].[Chambre] CHECK CONSTRAINT [FK_Chambre_Categories_CategoriesId]
GO
ALTER TABLE [dbo].[Chambre]  WITH CHECK ADD  CONSTRAINT [FK_Chambre_Hotels_HotelsId] FOREIGN KEY([HotelsId])
REFERENCES [dbo].[Hotels] ([HotelsId])
GO
ALTER TABLE [dbo].[Chambre] CHECK CONSTRAINT [FK_Chambre_Hotels_HotelsId]
GO
ALTER TABLE [dbo].[Commentaire]  WITH CHECK ADD  CONSTRAINT [FK_Commentaire_Client_ClientId] FOREIGN KEY([ClientId])
REFERENCES [dbo].[Client] ([ClientId])
GO
ALTER TABLE [dbo].[Commentaire] CHECK CONSTRAINT [FK_Commentaire_Client_ClientId]
GO
ALTER TABLE [dbo].[Commentaire]  WITH CHECK ADD  CONSTRAINT [FK_Commentaire_Hotels_HotelsId] FOREIGN KEY([HotelsId])
REFERENCES [dbo].[Hotels] ([HotelsId])
GO
ALTER TABLE [dbo].[Commentaire] CHECK CONSTRAINT [FK_Commentaire_Hotels_HotelsId]
GO
ALTER TABLE [dbo].[Concerner]  WITH CHECK ADD  CONSTRAINT [FK_Concerner_Chambre_ChambresChambreId] FOREIGN KEY([ChambresChambreId])
REFERENCES [dbo].[Chambre] ([ChambreId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Concerner] CHECK CONSTRAINT [FK_Concerner_Chambre_ChambresChambreId]
GO
ALTER TABLE [dbo].[Concerner]  WITH CHECK ADD  CONSTRAINT [FK_Concerner_Reservation_ReservationId] FOREIGN KEY([ReservationId])
REFERENCES [dbo].[Reservation] ([ReservationId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Concerner] CHECK CONSTRAINT [FK_Concerner_Reservation_ReservationId]
GO
ALTER TABLE [dbo].[Facture]  WITH CHECK ADD  CONSTRAINT [FK_Facture_Reservation_ReservationId] FOREIGN KEY([ReservationId])
REFERENCES [dbo].[Reservation] ([ReservationId])
GO
ALTER TABLE [dbo].[Facture] CHECK CONSTRAINT [FK_Facture_Reservation_ReservationId]
GO
ALTER TABLE [dbo].[Facture]  WITH CHECK ADD  CONSTRAINT [FK_Facture_Statuts_StatutId] FOREIGN KEY([StatutId])
REFERENCES [dbo].[Statuts] ([StatutId])
GO
ALTER TABLE [dbo].[Facture] CHECK CONSTRAINT [FK_Facture_Statuts_StatutId]
GO
ALTER TABLE [dbo].[Reservation]  WITH CHECK ADD  CONSTRAINT [FK_Reservation_Client_ClientId] FOREIGN KEY([ClientId])
REFERENCES [dbo].[Client] ([ClientId])
GO
ALTER TABLE [dbo].[Reservation] CHECK CONSTRAINT [FK_Reservation_Client_ClientId]
GO
ALTER TABLE [dbo].[Saisons]  WITH CHECK ADD  CONSTRAINT [FK_Saisons_Tarifss_TarifsId] FOREIGN KEY([TarifsId])
REFERENCES [dbo].[Tarifss] ([TarifsId])
GO
ALTER TABLE [dbo].[Saisons] CHECK CONSTRAINT [FK_Saisons_Tarifss_TarifsId]
GO
ALTER TABLE [dbo].[Services_Supplementaire]  WITH CHECK ADD  CONSTRAINT [FK_Services_Supplementaire_Hotels_HotelsId] FOREIGN KEY([HotelsId])
REFERENCES [dbo].[Hotels] ([HotelsId])
GO
ALTER TABLE [dbo].[Services_Supplementaire] CHECK CONSTRAINT [FK_Services_Supplementaire_Hotels_HotelsId]
GO
ALTER TABLE [dbo].[Tarifss]  WITH CHECK ADD  CONSTRAINT [FK_Tarifss_Categories_CategoriesId] FOREIGN KEY([CategoriesId])
REFERENCES [dbo].[Categories] ([CategoriesId])
GO
ALTER TABLE [dbo].[Tarifss] CHECK CONSTRAINT [FK_Tarifss_Categories_CategoriesId]
GO
USE [master]
GO
ALTER DATABASE [Hotel_management.Data] SET  READ_WRITE 
GO
