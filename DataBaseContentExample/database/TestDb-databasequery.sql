USE [master]
GO

/****** Object:  Database [TestDB]    Script Date: 2022-04-05 15:25:00 ******/
CREATE DATABASE [TestDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TestDB', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL14.DARTNET\MSSQL\DATA\TestDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TestDB_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL14.DARTNET\MSSQL\DATA\TestDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

ALTER DATABASE [TestDB] SET COMPATIBILITY_LEVEL = 140
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TestDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [TestDB] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [TestDB] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [TestDB] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [TestDB] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [TestDB] SET ARITHABORT OFF 
GO

ALTER DATABASE [TestDB] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [TestDB] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [TestDB] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [TestDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [TestDB] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [TestDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [TestDB] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [TestDB] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [TestDB] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [TestDB] SET  DISABLE_BROKER 
GO

ALTER DATABASE [TestDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [TestDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [TestDB] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [TestDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [TestDB] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [TestDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [TestDB] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [TestDB] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [TestDB] SET  MULTI_USER 
GO

ALTER DATABASE [TestDB] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [TestDB] SET DB_CHAINING OFF 
GO

ALTER DATABASE [TestDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [TestDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [TestDB] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [TestDB] SET QUERY_STORE = OFF
GO

USE [TestDB]
GO

ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO

ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO

ALTER DATABASE [TestDB] SET  READ_WRITE 
GO

