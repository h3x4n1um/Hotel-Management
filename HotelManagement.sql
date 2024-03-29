USE [master]
GO
/****** Object:  Database [HotelManagement]    Script Date: 15-Nov-21 10:25:44 PM ******/
CREATE DATABASE [HotelManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HotelManagement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\HotelManagement.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HotelManagement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\HotelManagement_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [HotelManagement] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HotelManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HotelManagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HotelManagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HotelManagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HotelManagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HotelManagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [HotelManagement] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HotelManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HotelManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HotelManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HotelManagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HotelManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HotelManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HotelManagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HotelManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HotelManagement] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HotelManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HotelManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HotelManagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HotelManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HotelManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HotelManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HotelManagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HotelManagement] SET RECOVERY FULL 
GO
ALTER DATABASE [HotelManagement] SET  MULTI_USER 
GO
ALTER DATABASE [HotelManagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HotelManagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HotelManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HotelManagement] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HotelManagement] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [HotelManagement] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'HotelManagement', N'ON'
GO
ALTER DATABASE [HotelManagement] SET QUERY_STORE = OFF
GO
USE [HotelManagement]
GO
/****** Object:  Table [dbo].[ACCOUNT]    Script Date: 15-Nov-21 10:25:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ACCOUNT](
	[USERNAME] [varchar](15) NOT NULL,
	[PASSWORD] [varchar](16) NOT NULL,
	[FULL_NAME] [nvarchar](100) NOT NULL,
	[GENDER] [bit] NULL,
	[PHONE] [varchar](20) NOT NULL,
	[ROLE] [char](2) NOT NULL,
 CONSTRAINT [PK_ACCOUNT] PRIMARY KEY CLUSTERED 
(
	[USERNAME] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BOOKING]    Script Date: 15-Nov-21 10:25:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BOOKING](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ROOM_ID] [char](3) NOT NULL,
	[ARRIVE] [date] NOT NULL,
	[DEPART] [date] NOT NULL,
	[CUSTOMER_NAME] [nvarchar](100) NOT NULL,
	[CUSTOMER_PHONE] [varchar](20) NOT NULL,
	[PAY] [int] NOT NULL,
 CONSTRAINT [PK_BOOKING] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ROLE]    Script Date: 15-Nov-21 10:25:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ROLE](
	[ROLE] [char](2) NOT NULL,
	[ROLE_NAME] [nvarchar](50) NOT NULL,
	[MANAGER] [bit] NOT NULL,
 CONSTRAINT [PK_ROLE] PRIMARY KEY CLUSTERED 
(
	[ROLE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ROOM]    Script Date: 15-Nov-21 10:25:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ROOM](
	[ROOM_ID] [char](3) NOT NULL,
	[PRICE] [int] NOT NULL,
 CONSTRAINT [PK_ROOM] PRIMARY KEY CLUSTERED 
(
	[ROOM_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ACCOUNT] ([USERNAME], [PASSWORD], [FULL_NAME], [GENDER], [PHONE], [ROLE]) VALUES (N'admin', N'admin', N'admin', 1, N'9876543210', N'AD')
INSERT [dbo].[ACCOUNT] ([USERNAME], [PASSWORD], [FULL_NAME], [GENDER], [PHONE], [ROLE]) VALUES (N'qltest', N'qltest', N'Test quản lý', NULL, N'999999999', N'QL')
INSERT [dbo].[ACCOUNT] ([USERNAME], [PASSWORD], [FULL_NAME], [GENDER], [PHONE], [ROLE]) VALUES (N'test', N'test', N'Test nhân viên', 0, N'0123456789', N'NV')
GO
SET IDENTITY_INSERT [dbo].[BOOKING] ON 

INSERT [dbo].[BOOKING] ([ID], [ROOM_ID], [ARRIVE], [DEPART], [CUSTOMER_NAME], [CUSTOMER_PHONE], [PAY]) VALUES (1, N'101', CAST(N'2021-10-01' AS Date), CAST(N'2021-12-01' AS Date), N'Bùi Thị B', N'4444', 7440000)
INSERT [dbo].[BOOKING] ([ID], [ROOM_ID], [ARRIVE], [DEPART], [CUSTOMER_NAME], [CUSTOMER_PHONE], [PAY]) VALUES (2, N'102', CAST(N'2021-10-01' AS Date), CAST(N'2022-01-01' AS Date), N'Lê Văn C', N'666666', 100000)
INSERT [dbo].[BOOKING] ([ID], [ROOM_ID], [ARRIVE], [DEPART], [CUSTOMER_NAME], [CUSTOMER_PHONE], [PAY]) VALUES (3, N'103', CAST(N'2021-10-01' AS Date), CAST(N'2021-12-01' AS Date), N'Nguyễn Văn Tèo', N'7777777', 100000)
INSERT [dbo].[BOOKING] ([ID], [ROOM_ID], [ARRIVE], [DEPART], [CUSTOMER_NAME], [CUSTOMER_PHONE], [PAY]) VALUES (4, N'104', CAST(N'2021-10-01' AS Date), CAST(N'2021-12-01' AS Date), N'Trần Văn A', N'123123123', 100000)
INSERT [dbo].[BOOKING] ([ID], [ROOM_ID], [ARRIVE], [DEPART], [CUSTOMER_NAME], [CUSTOMER_PHONE], [PAY]) VALUES (5, N'200', CAST(N'2021-11-13' AS Date), CAST(N'2021-11-13' AS Date), N'asdadasd', N'123123123', 100000)
INSERT [dbo].[BOOKING] ([ID], [ROOM_ID], [ARRIVE], [DEPART], [CUSTOMER_NAME], [CUSTOMER_PHONE], [PAY]) VALUES (6, N'201', CAST(N'2021-11-13' AS Date), CAST(N'2021-11-13' AS Date), N'', N'', 100000)
INSERT [dbo].[BOOKING] ([ID], [ROOM_ID], [ARRIVE], [DEPART], [CUSTOMER_NAME], [CUSTOMER_PHONE], [PAY]) VALUES (7, N'202', CAST(N'2021-11-14' AS Date), CAST(N'2021-11-22' AS Date), N'abc', N'1010101', 100000)
INSERT [dbo].[BOOKING] ([ID], [ROOM_ID], [ARRIVE], [DEPART], [CUSTOMER_NAME], [CUSTOMER_PHONE], [PAY]) VALUES (8, N'203', CAST(N'2021-11-14' AS Date), CAST(N'2021-11-14' AS Date), N'adifqhfi', N'eghwpiehgpw', 100000)
INSERT [dbo].[BOOKING] ([ID], [ROOM_ID], [ARRIVE], [DEPART], [CUSTOMER_NAME], [CUSTOMER_PHONE], [PAY]) VALUES (9, N'204', CAST(N'2021-11-14' AS Date), CAST(N'2021-11-14' AS Date), N'ahafuou', N'hishdwi', 100000)
INSERT [dbo].[BOOKING] ([ID], [ROOM_ID], [ARRIVE], [DEPART], [CUSTOMER_NAME], [CUSTOMER_PHONE], [PAY]) VALUES (10, N'100', CAST(N'2021-11-14' AS Date), CAST(N'2021-11-14' AS Date), N'ababababa', N'sbbhdhbshd', 100000)
INSERT [dbo].[BOOKING] ([ID], [ROOM_ID], [ARRIVE], [DEPART], [CUSTOMER_NAME], [CUSTOMER_PHONE], [PAY]) VALUES (11, N'200', CAST(N'2021-11-14' AS Date), CAST(N'2021-11-14' AS Date), N'ababababa', N'sbbhdhbshd', 100000)
INSERT [dbo].[BOOKING] ([ID], [ROOM_ID], [ARRIVE], [DEPART], [CUSTOMER_NAME], [CUSTOMER_PHONE], [PAY]) VALUES (12, N'105', CAST(N'2021-11-14' AS Date), CAST(N'2021-11-14' AS Date), N'ashfhq', N'huwghw', 200000)
SET IDENTITY_INSERT [dbo].[BOOKING] OFF
GO
INSERT [dbo].[ROLE] ([ROLE], [ROLE_NAME], [MANAGER]) VALUES (N'AD', N'Admin', 1)
INSERT [dbo].[ROLE] ([ROLE], [ROLE_NAME], [MANAGER]) VALUES (N'NV', N'Nhân viên', 0)
INSERT [dbo].[ROLE] ([ROLE], [ROLE_NAME], [MANAGER]) VALUES (N'QL', N'Quản lý', 1)
GO
INSERT [dbo].[ROOM] ([ROOM_ID], [PRICE]) VALUES (N'100', 100000)
INSERT [dbo].[ROOM] ([ROOM_ID], [PRICE]) VALUES (N'101', 120000)
INSERT [dbo].[ROOM] ([ROOM_ID], [PRICE]) VALUES (N'102', 140000)
INSERT [dbo].[ROOM] ([ROOM_ID], [PRICE]) VALUES (N'103', 160000)
INSERT [dbo].[ROOM] ([ROOM_ID], [PRICE]) VALUES (N'104', 180000)
INSERT [dbo].[ROOM] ([ROOM_ID], [PRICE]) VALUES (N'105', 200000)
INSERT [dbo].[ROOM] ([ROOM_ID], [PRICE]) VALUES (N'107', 220000)
INSERT [dbo].[ROOM] ([ROOM_ID], [PRICE]) VALUES (N'108', 240000)
INSERT [dbo].[ROOM] ([ROOM_ID], [PRICE]) VALUES (N'109', 260000)
INSERT [dbo].[ROOM] ([ROOM_ID], [PRICE]) VALUES (N'200', 50000)
INSERT [dbo].[ROOM] ([ROOM_ID], [PRICE]) VALUES (N'201', 60000)
INSERT [dbo].[ROOM] ([ROOM_ID], [PRICE]) VALUES (N'202', 70000)
INSERT [dbo].[ROOM] ([ROOM_ID], [PRICE]) VALUES (N'203', 80000)
INSERT [dbo].[ROOM] ([ROOM_ID], [PRICE]) VALUES (N'204', 90000)
INSERT [dbo].[ROOM] ([ROOM_ID], [PRICE]) VALUES (N'300', 12345)
GO
ALTER TABLE [dbo].[ACCOUNT]  WITH CHECK ADD  CONSTRAINT [FK_ACCOUNT_ROLE] FOREIGN KEY([ROLE])
REFERENCES [dbo].[ROLE] ([ROLE])
GO
ALTER TABLE [dbo].[ACCOUNT] CHECK CONSTRAINT [FK_ACCOUNT_ROLE]
GO
ALTER TABLE [dbo].[BOOKING]  WITH CHECK ADD  CONSTRAINT [FK_BOOKING_ROOM] FOREIGN KEY([ROOM_ID])
REFERENCES [dbo].[ROOM] ([ROOM_ID])
GO
ALTER TABLE [dbo].[BOOKING] CHECK CONSTRAINT [FK_BOOKING_ROOM]
GO
USE [master]
GO
ALTER DATABASE [HotelManagement] SET  READ_WRITE 
GO
