USE [master]
GO
/****** Object:  Database [BloodDonationMngSys]    Script Date: 1/3/2021 2:09:01 PM ******/
CREATE DATABASE [BloodDonationMngSys] ON  PRIMARY 
( NAME = N'BloodDonationMngSys', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\BloodDonationMngSys.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BloodDonationMngSys_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\BloodDonationMngSys_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [BloodDonationMngSys] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BloodDonationMngSys].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BloodDonationMngSys] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BloodDonationMngSys] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BloodDonationMngSys] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BloodDonationMngSys] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BloodDonationMngSys] SET ARITHABORT OFF 
GO
ALTER DATABASE [BloodDonationMngSys] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BloodDonationMngSys] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BloodDonationMngSys] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BloodDonationMngSys] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BloodDonationMngSys] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BloodDonationMngSys] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BloodDonationMngSys] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BloodDonationMngSys] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BloodDonationMngSys] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BloodDonationMngSys] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BloodDonationMngSys] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BloodDonationMngSys] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BloodDonationMngSys] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BloodDonationMngSys] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BloodDonationMngSys] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BloodDonationMngSys] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BloodDonationMngSys] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BloodDonationMngSys] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BloodDonationMngSys] SET  MULTI_USER 
GO
ALTER DATABASE [BloodDonationMngSys] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BloodDonationMngSys] SET DB_CHAINING OFF 
GO
USE [BloodDonationMngSys]
GO
/****** Object:  Table [dbo].[DonaterData]    Script Date: 1/3/2021 2:09:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonaterData](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[fullname] [varchar](50) NULL,
	[fathername] [varchar](50) NULL,
	[mothername] [varchar](50) NULL,
	[dob] [varchar](50) NULL,
	[mobno] [varchar](50) NULL,
	[gender] [varchar](50) NULL,
	[emailid] [varchar](50) NULL,
	[bloodgr] [varchar](50) NULL,
	[city] [varchar](50) NULL,
	[address] [varchar](max) NULL,
 CONSTRAINT [PK_DonaterData] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [BloodDonationMngSys] SET  READ_WRITE 
GO
