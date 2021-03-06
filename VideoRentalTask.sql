USE [master]
GO
/****** Object:  Database [videoRentalTask]    Script Date: 28/05/2021 12:46:45 AM ******/
CREATE DATABASE [videoRentalTask]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'videoRentalTask_Data', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\videoRentalTask.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'videoRentalTask_Log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\videoRentalTask.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [videoRentalTask] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [videoRentalTask].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [videoRentalTask] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [videoRentalTask] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [videoRentalTask] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [videoRentalTask] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [videoRentalTask] SET ARITHABORT OFF 
GO
ALTER DATABASE [videoRentalTask] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [videoRentalTask] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [videoRentalTask] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [videoRentalTask] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [videoRentalTask] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [videoRentalTask] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [videoRentalTask] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [videoRentalTask] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [videoRentalTask] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [videoRentalTask] SET  DISABLE_BROKER 
GO
ALTER DATABASE [videoRentalTask] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [videoRentalTask] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [videoRentalTask] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [videoRentalTask] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [videoRentalTask] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [videoRentalTask] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [videoRentalTask] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [videoRentalTask] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [videoRentalTask] SET  MULTI_USER 
GO
ALTER DATABASE [videoRentalTask] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [videoRentalTask] SET DB_CHAINING OFF 
GO
ALTER DATABASE [videoRentalTask] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [videoRentalTask] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [videoRentalTask] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [videoRentalTask] SET QUERY_STORE = OFF
GO
USE [videoRentalTask]
GO
/****** Object:  Table [dbo].[BookField]    Script Date: 28/05/2021 12:46:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookField](
	[BookID] [int] IDENTITY(1,1) NOT NULL,
	[CusID] [int] NULL,
	[VidID] [int] NULL,
	[BookVideo] [varchar](50) NULL,
	[ReturnVideo] [varchar](50) NULL,
 CONSTRAINT [PK_BookField] PRIMARY KEY CLUSTERED 
(
	[BookID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[customerField]    Script Date: 28/05/2021 12:46:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customerField](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Phone] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
 CONSTRAINT [PK_customerField] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VideoField]    Script Date: 28/05/2021 12:46:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VideoField](
	[VidID] [int] IDENTITY(1,1) NOT NULL,
	[title] [varchar](50) NULL,
	[ratting] [varchar](50) NULL,
	[year] [int] NULL,
	[cost] [int] NULL,
	[copies] [int] NULL,
	[plot] [varchar](50) NULL,
	[genre] [varchar](50) NULL,
 CONSTRAINT [PK_VideoField] PRIMARY KEY CLUSTERED 
(
	[VidID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[BookField] ON 

INSERT [dbo].[BookField] ([BookID], [CusID], [VidID], [BookVideo], [ReturnVideo]) VALUES (1, 1, 1, N'28/05/2021', N'28/05/2021')
SET IDENTITY_INSERT [dbo].[BookField] OFF
SET IDENTITY_INSERT [dbo].[customerField] ON 

INSERT [dbo].[customerField] ([ID], [Name], [Phone], [Address]) VALUES (1, N'Brook', N'648245445', N'New Zealand')
SET IDENTITY_INSERT [dbo].[customerField] OFF
SET IDENTITY_INSERT [dbo].[VideoField] ON 

INSERT [dbo].[VideoField] ([VidID], [title], [ratting], [year], [cost], [copies], [plot], [genre]) VALUES (1, N'SpiderMan', N'5', 2020, 5, 2, N'good', N'good')
SET IDENTITY_INSERT [dbo].[VideoField] OFF
USE [master]
GO
ALTER DATABASE [videoRentalTask] SET  READ_WRITE 
GO
