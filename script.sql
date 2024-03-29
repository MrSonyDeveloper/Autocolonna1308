USE [master]
GO
/****** Object:  Database [STAFF]    Script Date: 24.01.2021 0:35:17 ******/
CREATE DATABASE [STAFF]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'STAFF', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\STAFF.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'STAFF_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\STAFF_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [STAFF] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [STAFF].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [STAFF] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [STAFF] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [STAFF] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [STAFF] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [STAFF] SET ARITHABORT OFF 
GO
ALTER DATABASE [STAFF] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [STAFF] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [STAFF] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [STAFF] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [STAFF] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [STAFF] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [STAFF] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [STAFF] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [STAFF] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [STAFF] SET  DISABLE_BROKER 
GO
ALTER DATABASE [STAFF] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [STAFF] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [STAFF] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [STAFF] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [STAFF] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [STAFF] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [STAFF] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [STAFF] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [STAFF] SET  MULTI_USER 
GO
ALTER DATABASE [STAFF] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [STAFF] SET DB_CHAINING OFF 
GO
ALTER DATABASE [STAFF] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [STAFF] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [STAFF] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [STAFF] SET QUERY_STORE = OFF
GO
USE [STAFF]
GO
/****** Object:  Table [dbo].[Bol]    Script Date: 24.01.2021 0:35:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bol](
	[IdBol] [int] IDENTITY(1,1) NOT NULL,
	[IdChel] [int] NOT NULL,
	[BolStart] [date] NOT NULL,
	[BolFinish] [date] NULL,
 CONSTRAINT [PK_Bol] PRIMARY KEY CLUSTERED 
(
	[IdBol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Childs]    Script Date: 24.01.2021 0:35:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Childs](
	[id_child] [int] IDENTITY(1,1) NOT NULL,
	[id_chel] [int] NOT NULL,
	[LastName] [varchar](50) NULL,
	[FirstName] [varchar](50) NULL,
	[MiddleName] [varchar](50) NULL,
	[Birth] [date] NULL,
 CONSTRAINT [PK_Childs] PRIMARY KEY CLUSTERED 
(
	[id_child] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 24.01.2021 0:35:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[Id_chel] [int] IDENTITY(1,1) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[MiddleName] [varchar](50) NOT NULL,
	[Birth] [date] NOT NULL,
	[Edu] [varchar](500) NULL,
	[Gender] [varchar](50) NULL,
	[Address] [varchar](500) NULL,
	[Phone] [varchar](20) NULL,
	[IdPhoto] [int] NULL,
	[DateOfReceipt] [date] NOT NULL,
	[IdUchet] [int] NULL,
	[Position] [varchar](500) NULL,
	[Division] [varchar](500) NULL,
 CONSTRAINT [PK_Staff] PRIMARY KEY CLUSTERED 
(
	[Id_chel] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Uchet]    Script Date: 24.01.2021 0:35:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Uchet](
	[IdUchet] [int] IDENTITY(1,1) NOT NULL,
	[IdChel] [int] NOT NULL,
	[DaytimeStart] [datetime2](7) NULL,
	[DaytimeFinish] [datetime2](7) NULL,
 CONSTRAINT [PK_Uchet] PRIMARY KEY CLUSTERED 
(
	[IdUchet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vacation]    Script Date: 24.01.2021 0:35:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vacation](
	[IdVac] [int] IDENTITY(1,1) NOT NULL,
	[IdChel] [int] NOT NULL,
	[VacStart] [date] NOT NULL,
	[VacFinish] [date] NOT NULL,
 CONSTRAINT [PK_Vacation] PRIMARY KEY CLUSTERED 
(
	[IdVac] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Bol] ON 

INSERT [dbo].[Bol] ([IdBol], [IdChel], [BolStart], [BolFinish]) VALUES (1, 1, CAST(N'2020-10-20' AS Date), CAST(N'2020-10-31' AS Date))
INSERT [dbo].[Bol] ([IdBol], [IdChel], [BolStart], [BolFinish]) VALUES (2, 1, CAST(N'2021-01-01' AS Date), CAST(N'2021-01-11' AS Date))
INSERT [dbo].[Bol] ([IdBol], [IdChel], [BolStart], [BolFinish]) VALUES (7, 1, CAST(N'2021-01-13' AS Date), CAST(N'2021-01-23' AS Date))
INSERT [dbo].[Bol] ([IdBol], [IdChel], [BolStart], [BolFinish]) VALUES (8, 1, CAST(N'2021-01-19' AS Date), CAST(N'2021-01-23' AS Date))
SET IDENTITY_INSERT [dbo].[Bol] OFF
GO
SET IDENTITY_INSERT [dbo].[Childs] ON 

INSERT [dbo].[Childs] ([id_child], [id_chel], [LastName], [FirstName], [MiddleName], [Birth]) VALUES (1, 2, N'Игнатенков', N'Дмитрий', N'Дмитриевич', CAST(N'2027-11-15' AS Date))
INSERT [dbo].[Childs] ([id_child], [id_chel], [LastName], [FirstName], [MiddleName], [Birth]) VALUES (2, 2, N'Игнатенков', N'Егор', N'Дмитриевич', CAST(N'2030-05-13' AS Date))
INSERT [dbo].[Childs] ([id_child], [id_chel], [LastName], [FirstName], [MiddleName], [Birth]) VALUES (3, 2, N'Игнатенков', N'Владислав', N'Дмитриевич', CAST(N'2033-12-01' AS Date))
INSERT [dbo].[Childs] ([id_child], [id_chel], [LastName], [FirstName], [MiddleName], [Birth]) VALUES (4, 1, N'Кухарев', N'Дмитрий', N'Дмитриевич', CAST(N'2029-05-13' AS Date))
SET IDENTITY_INSERT [dbo].[Childs] OFF
GO
SET IDENTITY_INSERT [dbo].[Staff] ON 

INSERT [dbo].[Staff] ([Id_chel], [LastName], [FirstName], [MiddleName], [Birth], [Edu], [Gender], [Address], [Phone], [IdPhoto], [DateOfReceipt], [IdUchet], [Position], [Division]) VALUES (1, N'Кухарев ', N'Дмитрий', N'Юрьевич', CAST(N'2002-11-29' AS Date), N'Высшее образование - подготовка кадров высшей квалификации', N'Мужской', N'где-то тута', N'134761', 1, CAST(N'2021-01-12' AS Date), 1, N'Главный IT-специалист', N'Отдел по информационным технологиям')
INSERT [dbo].[Staff] ([Id_chel], [LastName], [FirstName], [MiddleName], [Birth], [Edu], [Gender], [Address], [Phone], [IdPhoto], [DateOfReceipt], [IdUchet], [Position], [Division]) VALUES (2, N'Игнатенков', N'Дмитрий', N'Владимирович', CAST(N'2002-10-31' AS Date), N'Высшее образование - бакалавриат', N'Мужской', N'Смоленск', N'1111', 1, CAST(N'2014-01-24' AS Date), 2, N'Главный IT-специалист', N'Отдел по информационным технологиям')
SET IDENTITY_INSERT [dbo].[Staff] OFF
GO
SET IDENTITY_INSERT [dbo].[Uchet] ON 

INSERT [dbo].[Uchet] ([IdUchet], [IdChel], [DaytimeStart], [DaytimeFinish]) VALUES (1, 1, CAST(N'2020-10-20T00:00:00.0000000' AS DateTime2), CAST(N'2020-10-20T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Uchet] ([IdUchet], [IdChel], [DaytimeStart], [DaytimeFinish]) VALUES (2, 2, CAST(N'2020-10-20T00:00:00.0000000' AS DateTime2), CAST(N'2020-10-20T00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Uchet] OFF
GO
SET IDENTITY_INSERT [dbo].[Vacation] ON 

INSERT [dbo].[Vacation] ([IdVac], [IdChel], [VacStart], [VacFinish]) VALUES (1, 2, CAST(N'2020-10-20' AS Date), CAST(N'2020-11-03' AS Date))
INSERT [dbo].[Vacation] ([IdVac], [IdChel], [VacStart], [VacFinish]) VALUES (2, 2, CAST(N'2021-01-05' AS Date), CAST(N'2021-02-05' AS Date))
SET IDENTITY_INSERT [dbo].[Vacation] OFF
GO
ALTER TABLE [dbo].[Bol]  WITH CHECK ADD  CONSTRAINT [FK_Bol_Staff1] FOREIGN KEY([IdChel])
REFERENCES [dbo].[Staff] ([Id_chel])
GO
ALTER TABLE [dbo].[Bol] CHECK CONSTRAINT [FK_Bol_Staff1]
GO
ALTER TABLE [dbo].[Childs]  WITH CHECK ADD  CONSTRAINT [FK_Childs_Staff] FOREIGN KEY([id_chel])
REFERENCES [dbo].[Staff] ([Id_chel])
GO
ALTER TABLE [dbo].[Childs] CHECK CONSTRAINT [FK_Childs_Staff]
GO
ALTER TABLE [dbo].[Staff]  WITH CHECK ADD  CONSTRAINT [FK_Staff_Uchet] FOREIGN KEY([IdUchet])
REFERENCES [dbo].[Uchet] ([IdUchet])
GO
ALTER TABLE [dbo].[Staff] CHECK CONSTRAINT [FK_Staff_Uchet]
GO
ALTER TABLE [dbo].[Uchet]  WITH CHECK ADD  CONSTRAINT [FK_Uchet_Staff] FOREIGN KEY([IdChel])
REFERENCES [dbo].[Staff] ([Id_chel])
GO
ALTER TABLE [dbo].[Uchet] CHECK CONSTRAINT [FK_Uchet_Staff]
GO
ALTER TABLE [dbo].[Uchet]  WITH CHECK ADD  CONSTRAINT [FK_Uchet_Staff1] FOREIGN KEY([IdChel])
REFERENCES [dbo].[Staff] ([Id_chel])
GO
ALTER TABLE [dbo].[Uchet] CHECK CONSTRAINT [FK_Uchet_Staff1]
GO
ALTER TABLE [dbo].[Vacation]  WITH CHECK ADD  CONSTRAINT [FK_Vacation_Staff] FOREIGN KEY([IdChel])
REFERENCES [dbo].[Staff] ([Id_chel])
GO
ALTER TABLE [dbo].[Vacation] CHECK CONSTRAINT [FK_Vacation_Staff]
GO
USE [master]
GO
ALTER DATABASE [STAFF] SET  READ_WRITE 
GO
