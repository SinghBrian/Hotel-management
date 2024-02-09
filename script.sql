USE [master]
GO

/****** Object:  Database [Hotel_management.Data]    Script Date: 09-02-24 09:29:52 ******/
CREATE DATABASE [Hotel_management.Data]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Hotel_management.Data', FILENAME = N'C:\Users\harji\Hotel_management.Data.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Hotel_management.Data_log', FILENAME = N'C:\Users\harji\Hotel_management.Data_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
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

ALTER DATABASE [Hotel_management.Data] SET  READ_WRITE 
GO

