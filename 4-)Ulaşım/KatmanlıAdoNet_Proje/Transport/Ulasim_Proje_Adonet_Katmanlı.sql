USE [master]
GO
/****** Object:  Database [Ulasim]    Script Date: 16.11.2022 19:28:27 ******/
CREATE DATABASE [Ulasim]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Ulasim', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Ulasim.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Ulasim_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Ulasim_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Ulasim] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Ulasim].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Ulasim] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Ulasim] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Ulasim] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Ulasim] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Ulasim] SET ARITHABORT OFF 
GO
ALTER DATABASE [Ulasim] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Ulasim] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Ulasim] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Ulasim] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Ulasim] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Ulasim] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Ulasim] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Ulasim] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Ulasim] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Ulasim] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Ulasim] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Ulasim] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Ulasim] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Ulasim] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Ulasim] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Ulasim] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Ulasim] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Ulasim] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Ulasim] SET  MULTI_USER 
GO
ALTER DATABASE [Ulasim] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Ulasim] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Ulasim] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Ulasim] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Ulasim] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Ulasim] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Ulasim] SET QUERY_STORE = OFF
GO
USE [Ulasim]
GO
/****** Object:  Table [dbo].[Biletler]    Script Date: 16.11.2022 19:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Biletler](
	[BiletNo] [int] IDENTITY(1,1) NOT NULL,
	[YolcuAdSoyad] [varchar](50) NULL,
	[YolcuKoltukNo] [int] NULL,
	[OtobusTipi] [varchar](50) NULL,
	[OtobusFirma] [varchar](50) NULL,
	[OtobusKalkisYeri] [varchar](50) NULL,
	[OtobusVarisYeri] [varchar](50) NULL,
	[OtobusKalkisZamani] [varchar](50) NULL,
	[OtobusVarisZamani] [varchar](50) NULL,
	[OtobusKalkisTarihi] [varchar](50) NULL,
	[OtobusVarisTarihi] [varchar](50) NULL,
	[BiletFiyati] [int] NULL,
	[YolcuNo] [int] NULL,
 CONSTRAINT [PK_Biletler] PRIMARY KEY CLUSTERED 
(
	[BiletNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hatlar]    Script Date: 16.11.2022 19:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hatlar](
	[HatNo] [int] IDENTITY(1,1) NOT NULL,
	[HatAdi] [varchar](50) NULL,
	[HatGuzergahBaslangici] [varchar](50) NULL,
	[HatGuzergahBitisi] [varchar](50) NULL,
 CONSTRAINT [PK_Hatlar] PRIMARY KEY CLUSTERED 
(
	[HatNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Otobusler]    Script Date: 16.11.2022 19:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Otobusler](
	[OtobusNo] [int] IDENTITY(1,1) NOT NULL,
	[OtobusFirma] [varchar](50) NULL,
	[OtobusPlaka] [varchar](50) NULL,
	[OtobusTipi] [varchar](50) NULL,
	[OtobusKapasite] [int] NULL,
	[OtobusSoforAdSoyad] [varchar](50) NULL,
	[HatNo] [int] NULL,
 CONSTRAINT [PK_Otobusler] PRIMARY KEY CLUSTERED 
(
	[OtobusNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Yolcular]    Script Date: 16.11.2022 19:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yolcular](
	[YolcuNo] [int] IDENTITY(1,1) NOT NULL,
	[YolcuAdSoyad] [varchar](50) NULL,
	[YolcuMail] [varchar](50) NULL,
	[YolcuTelefon] [varchar](50) NULL,
	[OtobusNo] [int] NULL,
 CONSTRAINT [PK_Yolcular] PRIMARY KEY CLUSTERED 
(
	[YolcuNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Hatlar] ON 

INSERT [dbo].[Hatlar] ([HatNo], [HatAdi], [HatGuzergahBaslangici], [HatGuzergahBitisi]) VALUES (1, N'İSTANBUL-ANKARA', N'İSTANBUL', N'ANKARA')
INSERT [dbo].[Hatlar] ([HatNo], [HatAdi], [HatGuzergahBaslangici], [HatGuzergahBitisi]) VALUES (2, N'İSTANBUL-KONYA', N'İSTANBUL', N'ESKİŞEHİR')
SET IDENTITY_INSERT [dbo].[Hatlar] OFF
GO
ALTER TABLE [dbo].[Biletler]  WITH CHECK ADD  CONSTRAINT [FK_Biletler_Yolcular] FOREIGN KEY([YolcuNo])
REFERENCES [dbo].[Yolcular] ([YolcuNo])
GO
ALTER TABLE [dbo].[Biletler] CHECK CONSTRAINT [FK_Biletler_Yolcular]
GO
ALTER TABLE [dbo].[Otobusler]  WITH CHECK ADD  CONSTRAINT [FK_Otobusler_Hatlar] FOREIGN KEY([HatNo])
REFERENCES [dbo].[Hatlar] ([HatNo])
GO
ALTER TABLE [dbo].[Otobusler] CHECK CONSTRAINT [FK_Otobusler_Hatlar]
GO
ALTER TABLE [dbo].[Yolcular]  WITH CHECK ADD  CONSTRAINT [FK_Yolcular_Otobusler] FOREIGN KEY([OtobusNo])
REFERENCES [dbo].[Otobusler] ([OtobusNo])
GO
ALTER TABLE [dbo].[Yolcular] CHECK CONSTRAINT [FK_Yolcular_Otobusler]
GO
/****** Object:  StoredProcedure [dbo].[BEkle]    Script Date: 16.11.2022 19:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[BEkle] 
@YolcuAdSoyad varchar(50),
@YolcuKoltukNo int,
@OtobusTipi varchar(50),
@OtobusFirma varchar(50),
@OtobusKalkisYeri varchar(50),
@OtobusVarisYeri varchar(50),
@OtobusKalkisZamani varchar(50),
@OtobusVarisZamani varchar(50),
@OtobusKalkisTarihi varchar(50),
@OtobusVarisTarihi varchar(50),
@BiletFiyati int,
@YolcuNo int
as begin 
insert into Biletler(YolcuAdSoyad,YolcuKoltukNo,OtobusTipi,OtobusFirma,OtobusKalkisYeri,OtobusVarisYeri,OtobusKalkisZamani,OtobusVarisZamani,OtobusKalkisTarihi,OtobusVarisTarihi,BiletFiyati,YolcuNo)
values(@YolcuAdSoyad,@YolcuKoltukNo,@OtobusTipi,@OtobusFirma,@OtobusKalkisYeri,@OtobusVarisYeri,@OtobusKalkisZamani,@OtobusVarisZamani,@OtobusKalkisTarihi,@OtobusVarisTarihi,@BiletFiyati,@YolcuNo)
end
GO
/****** Object:  StoredProcedure [dbo].[BListele]    Script Date: 16.11.2022 19:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[BListele]
as begin
select * from Biletler
end
GO
/****** Object:  StoredProcedure [dbo].[BSil]    Script Date: 16.11.2022 19:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[BSil]
@BiletNo int
as begin 
delete from Biletler where BiletNo=@BiletNo
end
GO
/****** Object:  StoredProcedure [dbo].[BYenile]    Script Date: 16.11.2022 19:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[BYenile]
@BiletNo int,
@YolcuAdSoyad varchar(50),
@YolcuKoltukNo int,
@OtobusTipi varchar(50),
@OtobusFirma varchar(50),
@OtobusKalkisYeri varchar(50),
@OtobusVarisYeri varchar(50),
@OtobusKalkisZamani varchar(50),
@OtobusVarisZamani varchar(50),
@OtobusKalkisTarihi varchar(50),
@OtobusVarisTarihi varchar(50),
@BiletFiyati int,
@YolcuNo int
as begin 
update Biletler set YolcuAdSoyad=@YolcuAdSoyad,YolcuKoltukNo=@YolcuKoltukNo,OtobusTipi=@OtobusTipi,OtobusFirma=@OtobusFirma,OtobusKalkisYeri=@OtobusKalkisYeri,OtobusVarisYeri=OtobusVarisYeri,@OtobusKalkisZamani=@OtobusKalkisZamani,OtobusVarisZamani=@OtobusVarisZamani,OtobusKalkisTarihi=@OtobusKalkisTarihi,OtobusVarisTarihi=@OtobusVarisTarihi,BiletFiyati=@BiletFiyati,YolcuNo=@YolcuNo where BiletNo=@BiletNo
end
GO
/****** Object:  StoredProcedure [dbo].[HEkle]    Script Date: 16.11.2022 19:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[HEkle] 
@HatAdi varchar(50),
@HatGuzergahBaslangici varchar(50),
@HatGuzergahBitisi varchar(50)
as begin 
insert into Hatlar(HatAdi,HatGuzergahBaslangici,HatGuzergahBitisi)
values(@HatAdi,@HatGuzergahBaslangici,@HatGuzergahBitisi)
end
GO
/****** Object:  StoredProcedure [dbo].[HListele]    Script Date: 16.11.2022 19:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[HListele]
as begin
select * from Hatlar
end
GO
/****** Object:  StoredProcedure [dbo].[HSil]    Script Date: 16.11.2022 19:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[HSil]
@HatNo int
as begin 
delete from Hatlar where HatNo=@HatNo
end
GO
/****** Object:  StoredProcedure [dbo].[HYenile]    Script Date: 16.11.2022 19:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[HYenile]
@HatNo int,
@HatAdi varchar(50),
@HatGuzergahBaslangici varchar(50),
@HatGuzergahBitisi varchar(50)
as begin 
update Hatlar set HatAdi=@HatAdi,HatGuzergahBaslangici=@HatGuzergahBaslangici,HatGuzergahBitisi=@HatGuzergahBitisi where HatNo=@HatNo
end
GO
/****** Object:  StoredProcedure [dbo].[OEkle]    Script Date: 16.11.2022 19:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[OEkle] 
@OtobusFirma varchar(50),
@OtobusPlaka varchar(50),
@OtobusTipi varchar(50),
@OtobusKapasite int,
@OtobusSoforAdSoyad varchar(50),
@HatNo int
as begin 
insert into Otobusler(OtobusFirma,OtobusPlaka,OtobusTipi,OtobusKapasite,OtobusSoforAdSoyad,HatNo)
values(@OtobusFirma,@OtobusPlaka,@OtobusTipi,@OtobusKapasite,@OtobusSoforAdSoyad,@HatNo)
end
GO
/****** Object:  StoredProcedure [dbo].[OListele]    Script Date: 16.11.2022 19:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[OListele]
as begin
select * from Otobusler
end
GO
/****** Object:  StoredProcedure [dbo].[OSil]    Script Date: 16.11.2022 19:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[OSil]
@OtobusNo int
as begin 
delete from Otobusler where OtobusNo=@OtobusNo
end
GO
/****** Object:  StoredProcedure [dbo].[OYenile]    Script Date: 16.11.2022 19:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[OYenile]
@OtobusNo int,
@OtobusFirma varchar(50),
@OtobusPlaka varchar(50),
@OtobusTipi varchar(50),
@OtobusKapasite int,
@OtobusSoforAdSoyad varchar(50),
@HatNo int
as begin 
update Otobusler set OtobusFirma=@OtobusFirma,OtobusPlaka=@OtobusPlaka,OtobusTipi=@OtobusTipi,OtobusKapasite=@OtobusKapasite,OtobusSoforAdSoyad=@OtobusSoforAdSoyad,HatNo=@HatNo where OtobusNo=@OtobusNo
end
GO
/****** Object:  StoredProcedure [dbo].[YEkle]    Script Date: 16.11.2022 19:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[YEkle] 
@YolcuAdSoyad varchar(50),
@YolcuMail varchar(50),
@YolcuTelefon varchar(50),
@OtobusNo int

as begin 
insert into Yolcular(YolcuAdSoyad,YolcuMail,YolcuTelefon,OtobusNo)
values(@YolcuAdSoyad,@YolcuMail,@YolcuTelefon,@OtobusNo)
end
GO
/****** Object:  StoredProcedure [dbo].[YListele]    Script Date: 16.11.2022 19:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[YListele]
as begin
select * from Yolcular
end
GO
/****** Object:  StoredProcedure [dbo].[YSil]    Script Date: 16.11.2022 19:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[YSil]
@YolcuNo int
as begin 
delete from Yolcular where YolcuNo=@YolcuNo
end
GO
/****** Object:  StoredProcedure [dbo].[YYenile]    Script Date: 16.11.2022 19:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[YYenile]
@YolcuNo int,
@YolcuAdSoyad varchar(50),
@YolcuMail varchar(50),
@YolcuTelefon varchar(50),
@OtobusNo int
as begin 
update Yolcular set YolcuAdSoyad=@YolcuAdSoyad,YolcuMail=@YolcuMail,YolcuTelefon=@YolcuTelefon,OtobusNo=OtobusNo where YolcuNo=@YolcuNo
end
GO
USE [master]
GO
ALTER DATABASE [Ulasim] SET  READ_WRITE 
GO
