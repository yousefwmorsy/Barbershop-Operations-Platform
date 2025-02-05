/****** Object:  Database [Barbershop Operations Platform DB]    Script Date: 28/12/2024 08:46:41 ******/
CREATE DATABASE [Barbershop Operations Platform DB]  (EDITION = 'GeneralPurpose', SERVICE_OBJECTIVE = 'GP_S_Gen5_2', MAXSIZE = 32 GB) WITH CATALOG_COLLATION = SQL_Latin1_General_CP1_CI_AS, LEDGER = OFF;
GO
ALTER DATABASE [Barbershop Operations Platform DB] SET COMPATIBILITY_LEVEL = 160
GO
ALTER DATABASE [Barbershop Operations Platform DB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Barbershop Operations Platform DB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Barbershop Operations Platform DB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Barbershop Operations Platform DB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Barbershop Operations Platform DB] SET ARITHABORT OFF 
GO
ALTER DATABASE [Barbershop Operations Platform DB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Barbershop Operations Platform DB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Barbershop Operations Platform DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Barbershop Operations Platform DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Barbershop Operations Platform DB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Barbershop Operations Platform DB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Barbershop Operations Platform DB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Barbershop Operations Platform DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Barbershop Operations Platform DB] SET ALLOW_SNAPSHOT_ISOLATION ON 
GO
ALTER DATABASE [Barbershop Operations Platform DB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Barbershop Operations Platform DB] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [Barbershop Operations Platform DB] SET  MULTI_USER 
GO
ALTER DATABASE [Barbershop Operations Platform DB] SET ENCRYPTION ON
GO
ALTER DATABASE [Barbershop Operations Platform DB] SET QUERY_STORE = ON
GO
ALTER DATABASE [Barbershop Operations Platform DB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 100, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
/*** The scripts of database scoped configurations in Azure should be executed inside the target database connection. ***/
GO
-- ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 8;
GO
/****** Object:  ColumnMasterKey [CMK_Auto1]    Script Date: 28/12/2024 08:46:42 ******/
CREATE COLUMN MASTER KEY [CMK_Auto1]
WITH
(
	KEY_STORE_PROVIDER_NAME = N'MSSQL_CERTIFICATE_STORE',
	KEY_PATH = N'CurrentUser/my/1D38ED9DF561E245B4BC5D41A9C9A004DE1D1057'
)
GO
/****** Object:  ColumnEncryptionKey [CEK_Auto1]    Script Date: 28/12/2024 08:46:42 ******/
CREATE COLUMN ENCRYPTION KEY [CEK_Auto1]
WITH VALUES
(
	COLUMN_MASTER_KEY = [CMK_Auto1],
	ALGORITHM = 'RSA_OAEP',
	ENCRYPTED_VALUE = 0x016E000001630075007200720065006E00740075007300650072002F006D0079002F0031006400330038006500640039006400660035003600310065003200340035006200340062006300350064003400310061003900630039006100300030003400640065003100640031003000350037009E8FF9A88DF826BB2D047C41F9BEDE2B5B37DD535BB136771C51E8E5B80DB4FBA696034801F4A17C619AFC6FC3BCB9A5E5C483B58014839A5684D61EE67C79817A781D52346D0C811766482F998E2FDCF18D38A24BF9ABB6E67C1903B59F4EDDD1489A6B6357AC713E499D4528C0516C15976819871CC526DE3F212AEC9AF53FBCE1303FFD59B267B53EC833C2F052EFC81965054E474D647E1AC0DA529A43FEF36DAECBEB68F6FF6048F9CF45186EF8521FB10086D9A0684A05710AEFF5E1DF6F1F81C002E402DF5D970FB8B27F4A234AFADAC016D27153B649FB84EFD90EA38B06443FB42F96AABC2AF7865BE1CFFD54A16106D410ECEE075095F24C4D59748C1188E78E12C9472DDE05BFD3469E2AF5CAB72C2AC9FCE3358D151499C0D5B047273B9E522FB226324E76910F5B6F8AA7728CB47CA384C78E6B72F61C00E81E5ED20CE41775360AA43FCF32EC991A9D39849852A49351A37EA4578063B98CB62BDD9D0459811DDB7CEFF18F65EE53265A773AF64AE3F9D1F22CD0735BE1E8401AEC2549566C94120000FC4ECB620BB483D6DAB8F91138D76EC722C66C0496EA79FE1360BD3A8EE08105141A102099426780D979289A913513938D87C0177A4198B51E9F4576FCFBD8683CDC5DBC4527A2D6F2E1EA0611663E9FFC82D8EF17790C6F6259503CFA08437B191A320ECDC0A286CF4C0A92E93AFD30DCBAC8C2C4BB
)
GO
/****** Object:  Table [dbo].[Appointment]    Script Date: 28/12/2024 08:46:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appointment](
	[AppointmentID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NOT NULL,
	[BarberID] [int] NULL,
	[ServiceID] [int] NOT NULL,
	[PaymentID] [int] NOT NULL,
	[CustComment] [varchar](300) NULL,
	[Rating] [int] NULL,
	[IncidentReport] [varchar](300) NULL,
	[AppointmentTime] [smalldatetime] NOT NULL,
	[Status] [varchar](50) NOT NULL,
 CONSTRAINT [PK__Appointm__8ECDFCA2EE731678] PRIMARY KEY CLUSTERED 
(
	[AppointmentID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Attendance_Log]    Script Date: 28/12/2024 08:46:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Attendance_Log](
	[emp_id] [int] NOT NULL,
	[date] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[emp_id] ASC,
	[date] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Barber]    Script Date: 28/12/2024 08:46:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Barber](
	[Emp_id] [int] NOT NULL,
	[Start_Time] [time](0) NOT NULL,
	[End_Time] [time](0) NOT NULL,
 CONSTRAINT [PK__Barber__263E2DD38F25097D] PRIMARY KEY CLUSTERED 
(
	[Emp_id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 28/12/2024 08:46:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustID] [int] IDENTITY(1,1) NOT NULL,
	[FName] [nvarchar](50) NOT NULL,
	[LName] [nvarchar](50) NOT NULL,
	[BDate] [date] NOT NULL,
	[Phone_Number] [varchar](12) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Points] [int] NULL,
	[Haircut_Details] [nvarchar](300) NULL,
PRIMARY KEY CLUSTERED 
(
	[CustID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DaysOffRequest]    Script Date: 28/12/2024 08:46:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DaysOffRequest](
	[RequestID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [int] NOT NULL,
	[ManagerID] [int] NOT NULL,
	[StartDate] [date] NOT NULL,
	[EndDate] [date] NOT NULL,
	[Status] [varchar](50) NOT NULL,
 CONSTRAINT [PK__DaysOffR__33A8519A55C6A1A3] PRIMARY KEY CLUSTERED 
(
	[RequestID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 28/12/2024 08:46:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[Emp_id] [int] IDENTITY(1,1) NOT NULL,
	[First_name] [varchar](50) NOT NULL,
	[Last_name] [varchar](50) NOT NULL,
	[Manager_id] [int] NULL,
	[Phone_number] [varchar](12) NOT NULL,
	[Address] [varchar](150) NULL,
	[Email] [varchar](100) NOT NULL,
	[Password] [varchar](50) NOT NULL,
 CONSTRAINT [PK__Employee__263E2DD35E9F378C] PRIMARY KEY CLUSTERED 
(
	[Emp_id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inventory]    Script Date: 28/12/2024 08:46:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventory](
	[supplyID] [int] IDENTITY(1,1) NOT NULL,
	[supply_Name] [varchar](50) NOT NULL,
	[Quantity] [int] NOT NULL,
	[Price] [int] NOT NULL,
 CONSTRAINT [PK__inventor__EF30F8A03CC45193] PRIMARY KEY CLUSTERED 
(
	[supplyID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ManagedEmployees]    Script Date: 28/12/2024 08:46:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ManagedEmployees](
	[EmpID] [int] NOT NULL,
	[OnDayOff] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[EmpID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Manager]    Script Date: 28/12/2024 08:46:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Manager](
	[Emp_id] [int] NOT NULL,
 CONSTRAINT [PK_Manager] PRIMARY KEY CLUSTERED 
(
	[Emp_id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Offers]    Script Date: 28/12/2024 08:46:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Offers](
	[Service_id] [int] NOT NULL,
	[Start_date] [date] NOT NULL,
	[End_date] [date] NOT NULL,
 CONSTRAINT [PK_Offers] PRIMARY KEY CLUSTERED 
(
	[Service_id] ASC,
	[Start_date] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payment_Transaction]    Script Date: 28/12/2024 08:46:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payment_Transaction](
	[payment_id] [int] IDENTITY(1,1) NOT NULL,
	[type] [varchar](50) NOT NULL,
	[payment_method] [varchar](50) NOT NULL,
	[status] [varchar](50) NOT NULL,
	[amount] [int] NOT NULL,
 CONSTRAINT [PK_Payment_Transaction] PRIMARY KEY CLUSTERED 
(
	[payment_id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhoneAppointment]    Script Date: 28/12/2024 08:46:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhoneAppointment](
	[EmpID] [int] NOT NULL,
	[AppID] [int] NOT NULL,
	[CustName] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[AppID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Receptionist]    Script Date: 28/12/2024 08:46:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Receptionist](
	[Emp_id] [int] NOT NULL,
 CONSTRAINT [PK__Receptio__263E2DD3A777FB3C] PRIMARY KEY CLUSTERED 
(
	[Emp_id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReceptionistPayment]    Script Date: 28/12/2024 08:46:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReceptionistPayment](
	[PaymentID] [int] NOT NULL,
	[EmpID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PaymentID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Service]    Script Date: 28/12/2024 08:46:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Service](
	[service_id] [int] IDENTITY(1,1) NOT NULL,
	[service_name] [varchar](50) NOT NULL,
	[price] [int] NOT NULL,
 CONSTRAINT [PK__Service__3E0DB8AFA1FEEA02] PRIMARY KEY CLUSTERED 
(
	[service_id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ServiceConsumes]    Script Date: 28/12/2024 08:46:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServiceConsumes](
	[ServiceID] [int] NOT NULL,
	[SupplyID] [int] NOT NULL,
	[QuantityConsumed] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ServiceID] ASC,
	[SupplyID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SuppliesBought]    Script Date: 28/12/2024 08:46:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SuppliesBought](
	[PaymentID] [int] NOT NULL,
	[SupplyID] [int] NOT NULL,
	[QuanityBought] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PaymentID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supply_Request]    Script Date: 28/12/2024 08:46:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supply_Request](
	[barber_id] [int] NOT NULL,
	[supply_id] [int] NOT NULL,
	[date] [date] NOT NULL,
	[quantity] [int] NOT NULL,
	[manager_id] [int] NOT NULL,
	[status] [varchar](50) NOT NULL,
 CONSTRAINT [PK__Supply_R__412F36610CFFA330] PRIMARY KEY CLUSTERED 
(
	[barber_id] ASC,
	[supply_id] ASC,
	[date] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Username_and_Password]    Script Date: 28/12/2024 08:46:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Username_and_Password](
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NULL,
 CONSTRAINT [PK_Username and Password] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Appointment] ON 

INSERT [dbo].[Appointment] ([AppointmentID], [CustomerID], [BarberID], [ServiceID], [PaymentID], [CustComment], [Rating], [IncidentReport], [AppointmentTime], [Status]) VALUES (1, 5, NULL, 1, 1, NULL, NULL, NULL, CAST(N'2004-02-10T00:00:00' AS SmallDateTime), N'pending')
INSERT [dbo].[Appointment] ([AppointmentID], [CustomerID], [BarberID], [ServiceID], [PaymentID], [CustComment], [Rating], [IncidentReport], [AppointmentTime], [Status]) VALUES (2, 5, NULL, 1, 1, NULL, NULL, NULL, CAST(N'2004-02-10T00:00:00' AS SmallDateTime), N'pending')
INSERT [dbo].[Appointment] ([AppointmentID], [CustomerID], [BarberID], [ServiceID], [PaymentID], [CustComment], [Rating], [IncidentReport], [AppointmentTime], [Status]) VALUES (11, 5, NULL, 4, 24, NULL, NULL, NULL, CAST(N'2024-12-27T00:00:00' AS SmallDateTime), N'Pending')
INSERT [dbo].[Appointment] ([AppointmentID], [CustomerID], [BarberID], [ServiceID], [PaymentID], [CustComment], [Rating], [IncidentReport], [AppointmentTime], [Status]) VALUES (12, 5, NULL, 2, 25, NULL, NULL, NULL, CAST(N'2024-12-27T00:00:00' AS SmallDateTime), N'Pending')
INSERT [dbo].[Appointment] ([AppointmentID], [CustomerID], [BarberID], [ServiceID], [PaymentID], [CustComment], [Rating], [IncidentReport], [AppointmentTime], [Status]) VALUES (13, 5, 70, 5, 26, NULL, NULL, NULL, CAST(N'2024-12-28T00:00:00' AS SmallDateTime), N'Assigned')
INSERT [dbo].[Appointment] ([AppointmentID], [CustomerID], [BarberID], [ServiceID], [PaymentID], [CustComment], [Rating], [IncidentReport], [AppointmentTime], [Status]) VALUES (14, 5, 70, 5, 27, N'good', 5, N'Very Good Customer', CAST(N'2024-12-27T00:00:00' AS SmallDateTime), N'Done')
INSERT [dbo].[Appointment] ([AppointmentID], [CustomerID], [BarberID], [ServiceID], [PaymentID], [CustComment], [Rating], [IncidentReport], [AppointmentTime], [Status]) VALUES (15, 5, NULL, 2, 28, NULL, NULL, NULL, CAST(N'2024-12-27T00:00:00' AS SmallDateTime), N'Pending')
INSERT [dbo].[Appointment] ([AppointmentID], [CustomerID], [BarberID], [ServiceID], [PaymentID], [CustComment], [Rating], [IncidentReport], [AppointmentTime], [Status]) VALUES (21, 5, NULL, 4, 36, NULL, NULL, NULL, CAST(N'2024-12-27T12:00:00' AS SmallDateTime), N'Pending')
INSERT [dbo].[Appointment] ([AppointmentID], [CustomerID], [BarberID], [ServiceID], [PaymentID], [CustComment], [Rating], [IncidentReport], [AppointmentTime], [Status]) VALUES (24, 5, NULL, 4, 42, NULL, NULL, NULL, CAST(N'2025-01-03T15:00:00' AS SmallDateTime), N'Pending')
INSERT [dbo].[Appointment] ([AppointmentID], [CustomerID], [BarberID], [ServiceID], [PaymentID], [CustComment], [Rating], [IncidentReport], [AppointmentTime], [Status]) VALUES (25, 5, NULL, 7, 44, NULL, NULL, NULL, CAST(N'2025-01-03T10:00:00' AS SmallDateTime), N'Done')
INSERT [dbo].[Appointment] ([AppointmentID], [CustomerID], [BarberID], [ServiceID], [PaymentID], [CustComment], [Rating], [IncidentReport], [AppointmentTime], [Status]) VALUES (26, 5, NULL, 4, 48, NULL, NULL, NULL, CAST(N'2025-01-02T15:00:00' AS SmallDateTime), N'Pending')
INSERT [dbo].[Appointment] ([AppointmentID], [CustomerID], [BarberID], [ServiceID], [PaymentID], [CustComment], [Rating], [IncidentReport], [AppointmentTime], [Status]) VALUES (27, 5, NULL, 5, 49, NULL, NULL, NULL, CAST(N'2025-01-02T15:00:00' AS SmallDateTime), N'Pending')
INSERT [dbo].[Appointment] ([AppointmentID], [CustomerID], [BarberID], [ServiceID], [PaymentID], [CustComment], [Rating], [IncidentReport], [AppointmentTime], [Status]) VALUES (28, 5, NULL, 5, 50, NULL, NULL, NULL, CAST(N'2025-01-02T15:00:00' AS SmallDateTime), N'Pending')
INSERT [dbo].[Appointment] ([AppointmentID], [CustomerID], [BarberID], [ServiceID], [PaymentID], [CustComment], [Rating], [IncidentReport], [AppointmentTime], [Status]) VALUES (29, 5, NULL, 5, 51, NULL, NULL, NULL, CAST(N'2025-01-02T15:00:00' AS SmallDateTime), N'Done')
INSERT [dbo].[Appointment] ([AppointmentID], [CustomerID], [BarberID], [ServiceID], [PaymentID], [CustComment], [Rating], [IncidentReport], [AppointmentTime], [Status]) VALUES (34, 12, 70, 1, 65, NULL, NULL, N'test', CAST(N'2024-12-28T09:00:00' AS SmallDateTime), N'Done')
INSERT [dbo].[Appointment] ([AppointmentID], [CustomerID], [BarberID], [ServiceID], [PaymentID], [CustComment], [Rating], [IncidentReport], [AppointmentTime], [Status]) VALUES (35, 12, 66, 3, 66, NULL, NULL, NULL, CAST(N'2024-12-28T12:00:00' AS SmallDateTime), N'Done')
INSERT [dbo].[Appointment] ([AppointmentID], [CustomerID], [BarberID], [ServiceID], [PaymentID], [CustComment], [Rating], [IncidentReport], [AppointmentTime], [Status]) VALUES (36, 12, 68, 1, 67, NULL, NULL, NULL, CAST(N'2024-12-28T15:00:00' AS SmallDateTime), N'Done')
INSERT [dbo].[Appointment] ([AppointmentID], [CustomerID], [BarberID], [ServiceID], [PaymentID], [CustComment], [Rating], [IncidentReport], [AppointmentTime], [Status]) VALUES (37, 12, 70, 3, 68, NULL, NULL, N'Good ?', CAST(N'2024-12-28T04:00:00' AS SmallDateTime), N'Done')
INSERT [dbo].[Appointment] ([AppointmentID], [CustomerID], [BarberID], [ServiceID], [PaymentID], [CustComment], [Rating], [IncidentReport], [AppointmentTime], [Status]) VALUES (38, 5, 70, 4, 70, NULL, NULL, NULL, CAST(N'2024-12-28T05:00:00' AS SmallDateTime), N'Done')
INSERT [dbo].[Appointment] ([AppointmentID], [CustomerID], [BarberID], [ServiceID], [PaymentID], [CustComment], [Rating], [IncidentReport], [AppointmentTime], [Status]) VALUES (40, 13, 70, 6, 72, N'thank u', 5, NULL, CAST(N'2024-12-28T18:00:00' AS SmallDateTime), N'Done')
INSERT [dbo].[Appointment] ([AppointmentID], [CustomerID], [BarberID], [ServiceID], [PaymentID], [CustComment], [Rating], [IncidentReport], [AppointmentTime], [Status]) VALUES (42, 13, 68, 3, 75, NULL, NULL, NULL, CAST(N'2024-12-28T16:00:00' AS SmallDateTime), N'Assigned')
INSERT [dbo].[Appointment] ([AppointmentID], [CustomerID], [BarberID], [ServiceID], [PaymentID], [CustComment], [Rating], [IncidentReport], [AppointmentTime], [Status]) VALUES (43, 15, NULL, 1, 76, NULL, NULL, NULL, CAST(N'2024-12-29T12:00:00' AS SmallDateTime), N'Pending')
INSERT [dbo].[Appointment] ([AppointmentID], [CustomerID], [BarberID], [ServiceID], [PaymentID], [CustComment], [Rating], [IncidentReport], [AppointmentTime], [Status]) VALUES (44, 15, NULL, 1, 77, NULL, NULL, NULL, CAST(N'2024-12-29T12:00:00' AS SmallDateTime), N'Pending')
INSERT [dbo].[Appointment] ([AppointmentID], [CustomerID], [BarberID], [ServiceID], [PaymentID], [CustComment], [Rating], [IncidentReport], [AppointmentTime], [Status]) VALUES (47, 13, NULL, 3, 80, NULL, NULL, NULL, CAST(N'2024-12-28T12:00:00' AS SmallDateTime), N'Pending')
INSERT [dbo].[Appointment] ([AppointmentID], [CustomerID], [BarberID], [ServiceID], [PaymentID], [CustComment], [Rating], [IncidentReport], [AppointmentTime], [Status]) VALUES (48, 13, NULL, 4, 81, NULL, NULL, NULL, CAST(N'2024-12-28T15:00:00' AS SmallDateTime), N'Pending')
INSERT [dbo].[Appointment] ([AppointmentID], [CustomerID], [BarberID], [ServiceID], [PaymentID], [CustComment], [Rating], [IncidentReport], [AppointmentTime], [Status]) VALUES (49, 13, NULL, 1, 82, NULL, NULL, NULL, CAST(N'2024-12-28T08:00:00' AS SmallDateTime), N'Done')
INSERT [dbo].[Appointment] ([AppointmentID], [CustomerID], [BarberID], [ServiceID], [PaymentID], [CustComment], [Rating], [IncidentReport], [AppointmentTime], [Status]) VALUES (50, 13, NULL, 2, 83, NULL, NULL, NULL, CAST(N'2024-12-28T15:00:00' AS SmallDateTime), N'Done')
INSERT [dbo].[Appointment] ([AppointmentID], [CustomerID], [BarberID], [ServiceID], [PaymentID], [CustComment], [Rating], [IncidentReport], [AppointmentTime], [Status]) VALUES (51, 7, 70, 1, 86, NULL, NULL, NULL, CAST(N'2024-12-28T16:00:00' AS SmallDateTime), N'Done')
INSERT [dbo].[Appointment] ([AppointmentID], [CustomerID], [BarberID], [ServiceID], [PaymentID], [CustComment], [Rating], [IncidentReport], [AppointmentTime], [Status]) VALUES (54, 12, NULL, 7, 91, NULL, NULL, NULL, CAST(N'2024-12-28T17:00:00' AS SmallDateTime), N'Done')
INSERT [dbo].[Appointment] ([AppointmentID], [CustomerID], [BarberID], [ServiceID], [PaymentID], [CustComment], [Rating], [IncidentReport], [AppointmentTime], [Status]) VALUES (55, 12, NULL, 7, 92, NULL, NULL, NULL, CAST(N'2024-12-28T06:00:00' AS SmallDateTime), N'Pending')
INSERT [dbo].[Appointment] ([AppointmentID], [CustomerID], [BarberID], [ServiceID], [PaymentID], [CustComment], [Rating], [IncidentReport], [AppointmentTime], [Status]) VALUES (56, 12, NULL, 7, 93, NULL, NULL, NULL, CAST(N'2024-12-28T16:00:00' AS SmallDateTime), N'Done')
SET IDENTITY_INSERT [dbo].[Appointment] OFF
GO
INSERT [dbo].[Attendance_Log] ([emp_id], [date]) VALUES (2, CAST(N'2024-12-27' AS Date))
INSERT [dbo].[Attendance_Log] ([emp_id], [date]) VALUES (70, CAST(N'2024-12-28' AS Date))
GO
INSERT [dbo].[Barber] ([Emp_id], [Start_Time], [End_Time]) VALUES (2, CAST(N'09:00:00' AS Time), CAST(N'16:00:00' AS Time))
INSERT [dbo].[Barber] ([Emp_id], [Start_Time], [End_Time]) VALUES (66, CAST(N'08:00:00' AS Time), CAST(N'14:00:00' AS Time))
INSERT [dbo].[Barber] ([Emp_id], [Start_Time], [End_Time]) VALUES (68, CAST(N'10:00:00' AS Time), CAST(N'17:00:00' AS Time))
INSERT [dbo].[Barber] ([Emp_id], [Start_Time], [End_Time]) VALUES (70, CAST(N'00:00:00' AS Time), CAST(N'23:59:59' AS Time))
INSERT [dbo].[Barber] ([Emp_id], [Start_Time], [End_Time]) VALUES (82, CAST(N'09:00:00' AS Time), CAST(N'16:00:00' AS Time))
INSERT [dbo].[Barber] ([Emp_id], [Start_Time], [End_Time]) VALUES (84, CAST(N'08:00:00' AS Time), CAST(N'16:00:00' AS Time))
INSERT [dbo].[Barber] ([Emp_id], [Start_Time], [End_Time]) VALUES (85, CAST(N'08:00:00' AS Time), CAST(N'21:00:00' AS Time))
INSERT [dbo].[Barber] ([Emp_id], [Start_Time], [End_Time]) VALUES (87, CAST(N'16:00:00' AS Time), CAST(N'20:00:00' AS Time))
INSERT [dbo].[Barber] ([Emp_id], [Start_Time], [End_Time]) VALUES (89, CAST(N'13:00:00' AS Time), CAST(N'22:00:00' AS Time))
INSERT [dbo].[Barber] ([Emp_id], [Start_Time], [End_Time]) VALUES (90, CAST(N'12:00:00' AS Time), CAST(N'17:00:00' AS Time))
INSERT [dbo].[Barber] ([Emp_id], [Start_Time], [End_Time]) VALUES (91, CAST(N'12:00:00' AS Time), CAST(N'17:00:00' AS Time))
INSERT [dbo].[Barber] ([Emp_id], [Start_Time], [End_Time]) VALUES (92, CAST(N'09:00:00' AS Time), CAST(N'13:00:00' AS Time))
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([CustID], [FName], [LName], [BDate], [Phone_Number], [Email], [Password], [Points], [Haircut_Details]) VALUES (5, N'Galal', N'Gaafr', CAST(N'2004-02-10' AS Date), N'01111111115', N'galal@email.com', N'dee', 107, N'short hair')
INSERT [dbo].[Customer] ([CustID], [FName], [LName], [BDate], [Phone_Number], [Email], [Password], [Points], [Haircut_Details]) VALUES (6, N'ahmed', N'abdel el jalel', CAST(N'2024-12-18' AS Date), N'01116666666', N'ahmed@email.com', N'ahmed', 0, N'Cut the beard, Trim the hair')
INSERT [dbo].[Customer] ([CustID], [FName], [LName], [BDate], [Phone_Number], [Email], [Password], [Points], [Haircut_Details]) VALUES (7, N'abdelrahman', N'faseeh', CAST(N'2024-12-26' AS Date), N'01111111111', N'abdelrahman@', N'faseeh', 0, N'1mm')
INSERT [dbo].[Customer] ([CustID], [FName], [LName], [BDate], [Phone_Number], [Email], [Password], [Points], [Haircut_Details]) VALUES (8, N'ziad', N'abdelraouf', CAST(N'2024-12-04' AS Date), N'01096452408', N'ziad@email', N'1234', 0, N'Bald')
INSERT [dbo].[Customer] ([CustID], [FName], [LName], [BDate], [Phone_Number], [Email], [Password], [Points], [Haircut_Details]) VALUES (10, N'yousseg', N'morsy', CAST(N'2024-12-27' AS Date), N'00033333333', N'gg@email.com', N'helloworld', 0, N'Remove Beard')
INSERT [dbo].[Customer] ([CustID], [FName], [LName], [BDate], [Phone_Number], [Email], [Password], [Points], [Haircut_Details]) VALUES (11, N'yousef', N'Morsy', CAST(N'2024-12-27' AS Date), N'01090799694', N'youssefw@morsy@gmail.com', N'helloworld', 0, N'Shorten the hair')
INSERT [dbo].[Customer] ([CustID], [FName], [LName], [BDate], [Phone_Number], [Email], [Password], [Points], [Haircut_Details]) VALUES (12, N'Offline', N'Customer', CAST(N'2024-12-28' AS Date), N'00000000000', N'offlineCust@email.com', N'0', 0, N'PER CUSTOMER')
INSERT [dbo].[Customer] ([CustID], [FName], [LName], [BDate], [Phone_Number], [Email], [Password], [Points], [Haircut_Details]) VALUES (13, N'Yousef', N'M.', CAST(N'2024-12-28' AS Date), N'01090699596', N'y@mail.com', N'hello', 8, N'Haircut')
INSERT [dbo].[Customer] ([CustID], [FName], [LName], [BDate], [Phone_Number], [Email], [Password], [Points], [Haircut_Details]) VALUES (15, N'mohamed', N'mohamed', CAST(N'2024-12-28' AS Date), N'00000000010', N'mohamed@email.com', N'cce', 89, N'same height, 5mm')
INSERT [dbo].[Customer] ([CustID], [FName], [LName], [BDate], [Phone_Number], [Email], [Password], [Points], [Haircut_Details]) VALUES (16, N'Houras', N'Emad', CAST(N'2005-02-11' AS Date), N'01113355779', N'houras', N'houras@123', 0, N'Leave the beard')
INSERT [dbo].[Customer] ([CustID], [FName], [LName], [BDate], [Phone_Number], [Email], [Password], [Points], [Haircut_Details]) VALUES (17, N'mahmoud', N'hassa', CAST(N'2004-02-09' AS Date), N'01999999999', N'mahmoud@email.com', N'mahmoud', NULL, NULL)
INSERT [dbo].[Customer] ([CustID], [FName], [LName], [BDate], [Phone_Number], [Email], [Password], [Points], [Haircut_Details]) VALUES (18, N'hany', N'ahmed', CAST(N'2001-07-13' AS Date), N'01003627307', N'hany@email.com', N'333', 0, NULL)
INSERT [dbo].[Customer] ([CustID], [FName], [LName], [BDate], [Phone_Number], [Email], [Password], [Points], [Haircut_Details]) VALUES (19, N'karem', N'karam', CAST(N'2001-06-19' AS Date), N'01003462918', N'karem@email.com', N'222', 0, NULL)
INSERT [dbo].[Customer] ([CustID], [FName], [LName], [BDate], [Phone_Number], [Email], [Password], [Points], [Haircut_Details]) VALUES (20, N'karam', N'karem', CAST(N'2001-06-19' AS Date), N'01003463918', N'karam@email.com', N'222', 0, NULL)
INSERT [dbo].[Customer] ([CustID], [FName], [LName], [BDate], [Phone_Number], [Email], [Password], [Points], [Haircut_Details]) VALUES (21, N'yasin', N'karem', CAST(N'2001-06-19' AS Date), N'01003463948', N'yasin@email.com', N'222', 0, NULL)
INSERT [dbo].[Customer] ([CustID], [FName], [LName], [BDate], [Phone_Number], [Email], [Password], [Points], [Haircut_Details]) VALUES (24, N'mohamed', N'mohamed', CAST(N'2001-06-19' AS Date), N'01003461941', N'mohamed@gmail.com', N'eee', 0, NULL)
INSERT [dbo].[Customer] ([CustID], [FName], [LName], [BDate], [Phone_Number], [Email], [Password], [Points], [Haircut_Details]) VALUES (25, N'fares', N'mahmoud', CAST(N'2001-06-19' AS Date), N'01003455941', N'fares@gmail.com', N'eee', 0, NULL)
INSERT [dbo].[Customer] ([CustID], [FName], [LName], [BDate], [Phone_Number], [Email], [Password], [Points], [Haircut_Details]) VALUES (27, N'nasser', N'fares', CAST(N'2001-06-05' AS Date), N'01003451941', N'nasser@hotmail.com', N'hhh', 0, NULL)
INSERT [dbo].[Customer] ([CustID], [FName], [LName], [BDate], [Phone_Number], [Email], [Password], [Points], [Haircut_Details]) VALUES (29, N'yasser', N'fares', CAST(N'2001-06-09' AS Date), N'01003451955', N'yasser@email.com', N'213', 0, NULL)
INSERT [dbo].[Customer] ([CustID], [FName], [LName], [BDate], [Phone_Number], [Email], [Password], [Points], [Haircut_Details]) VALUES (30, N'yasser', N'mohamed', CAST(N'2001-06-24' AS Date), N'01003451995', N'yassemohamedr@email.com', N'yasser', 0, NULL)
INSERT [dbo].[Customer] ([CustID], [FName], [LName], [BDate], [Phone_Number], [Email], [Password], [Points], [Haircut_Details]) VALUES (31, N'omar', N'mohamed', CAST(N'2001-06-24' AS Date), N'01043451995', N'omarmohamed@email.com', N'omarmohamed', 0, NULL)
SET IDENTITY_INSERT [dbo].[Customer] OFF
GO
SET IDENTITY_INSERT [dbo].[DaysOffRequest] ON 

INSERT [dbo].[DaysOffRequest] ([RequestID], [EmployeeID], [ManagerID], [StartDate], [EndDate], [Status]) VALUES (1, 2, 11, CAST(N'2024-12-12' AS Date), CAST(N'2024-12-15' AS Date), N'Accepted')
INSERT [dbo].[DaysOffRequest] ([RequestID], [EmployeeID], [ManagerID], [StartDate], [EndDate], [Status]) VALUES (4, 2, 11, CAST(N'2024-12-28' AS Date), CAST(N'2024-12-29' AS Date), N'Accepted')
INSERT [dbo].[DaysOffRequest] ([RequestID], [EmployeeID], [ManagerID], [StartDate], [EndDate], [Status]) VALUES (11, 2, 11, CAST(N'2024-12-30' AS Date), CAST(N'2024-12-31' AS Date), N'Pending')
INSERT [dbo].[DaysOffRequest] ([RequestID], [EmployeeID], [ManagerID], [StartDate], [EndDate], [Status]) VALUES (12, 63, 11, CAST(N'2024-12-27' AS Date), CAST(N'2024-12-27' AS Date), N'Pending')
INSERT [dbo].[DaysOffRequest] ([RequestID], [EmployeeID], [ManagerID], [StartDate], [EndDate], [Status]) VALUES (13, 63, 11, CAST(N'2024-12-28' AS Date), CAST(N'2024-12-28' AS Date), N'Declined')
INSERT [dbo].[DaysOffRequest] ([RequestID], [EmployeeID], [ManagerID], [StartDate], [EndDate], [Status]) VALUES (14, 63, 11, CAST(N'2024-12-28' AS Date), CAST(N'2024-12-29' AS Date), N'Accepted')
SET IDENTITY_INSERT [dbo].[DaysOffRequest] OFF
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([Emp_id], [First_name], [Last_name], [Manager_id], [Phone_number], [Address], [Email], [Password]) VALUES (1, N'Super', N'Manager', NULL, N'0', N'Ismailia', N'super@manager.com', N'New Password')
INSERT [dbo].[Employee] ([Emp_id], [First_name], [Last_name], [Manager_id], [Phone_number], [Address], [Email], [Password]) VALUES (2, N'Jacobs', N'Mathew', 11, N'011000000000', N'', N'JacobsMathew@Bemail.com', N'B1')
INSERT [dbo].[Employee] ([Emp_id], [First_name], [Last_name], [Manager_id], [Phone_number], [Address], [Email], [Password]) VALUES (11, N'Ahmed', N'Mohammed', 103, N'01032942805', N'Ismailia', N'Ahmed@Mmail.com', N'New Password')
INSERT [dbo].[Employee] ([Emp_id], [First_name], [Last_name], [Manager_id], [Phone_number], [Address], [Email], [Password]) VALUES (53, N'Brad', N'Selon', 11, N'01100000001', N'Ismailia', N'BradSelon@Bmail.com', N'11223344')
INSERT [dbo].[Employee] ([Emp_id], [First_name], [Last_name], [Manager_id], [Phone_number], [Address], [Email], [Password]) VALUES (54, N'Robert', N'Jacob', 11, N'01200000000', N'Ismailia', N'RobertJacob@Bmail.com', N'11223344')
INSERT [dbo].[Employee] ([Emp_id], [First_name], [Last_name], [Manager_id], [Phone_number], [Address], [Email], [Password]) VALUES (63, N'Receptionist', N'Test', 11, N'123456789234', NULL, N'hello@mail.com', N'12345678')
INSERT [dbo].[Employee] ([Emp_id], [First_name], [Last_name], [Manager_id], [Phone_number], [Address], [Email], [Password]) VALUES (66, N'Ashraf', N'Hakimi', 1, N'01010101010', N'Ismailia', N'a.hakimi@Bmail.com', N'11223344')
INSERT [dbo].[Employee] ([Emp_id], [First_name], [Last_name], [Manager_id], [Phone_number], [Address], [Email], [Password]) VALUES (68, N'Marawan', N'Tayson', 100, N'01011121112', N'Ismailia', N'm.Tayson@Bmail.com', N'11121112')
INSERT [dbo].[Employee] ([Emp_id], [First_name], [Last_name], [Manager_id], [Phone_number], [Address], [Email], [Password]) VALUES (70, N'Full', N'Time', 100, N'01090799694', NULL, N'fulltime@email.com', N'44444444444444444')
INSERT [dbo].[Employee] ([Emp_id], [First_name], [Last_name], [Manager_id], [Phone_number], [Address], [Email], [Password]) VALUES (79, N'Yousef', N'Morsy', 11, N'01090799690', NULL, N'yousefwmorsy@gmail.com', N'12345')
INSERT [dbo].[Employee] ([Emp_id], [First_name], [Last_name], [Manager_id], [Phone_number], [Address], [Email], [Password]) VALUES (80, N'mahmoud', N'hany', 103, N'010093338822', NULL, N'mm@email.com', N'2132')
INSERT [dbo].[Employee] ([Emp_id], [First_name], [Last_name], [Manager_id], [Phone_number], [Address], [Email], [Password]) VALUES (82, N'mahmoud', N'ahmed', 103, N'01000002233', N'giza', N'mahmodu@email.com', N'112')
INSERT [dbo].[Employee] ([Emp_id], [First_name], [Last_name], [Manager_id], [Phone_number], [Address], [Email], [Password]) VALUES (84, N'Yousef', N'Khaled', 100, N'010101023', N'Cairo', N'y.khaled@email.com', N'123@123')
INSERT [dbo].[Employee] ([Emp_id], [First_name], [Last_name], [Manager_id], [Phone_number], [Address], [Email], [Password]) VALUES (85, N'mahmoud', N'ahmed', 102, N'01002002222', N'giza', N'mahmodumahmoud@Gmail.com', N'1155')
INSERT [dbo].[Employee] ([Emp_id], [First_name], [Last_name], [Manager_id], [Phone_number], [Address], [Email], [Password]) VALUES (86, N'mahmoud', N'ahmed', 102, N'01063637278', N'giza', N'ahmed@@email', N'0909')
INSERT [dbo].[Employee] ([Emp_id], [First_name], [Last_name], [Manager_id], [Phone_number], [Address], [Email], [Password]) VALUES (87, N'Hakim', N'Khaled', 100, N'010101013', N'Giza', N'hakim_k@email.com', N'123@123')
INSERT [dbo].[Employee] ([Emp_id], [First_name], [Last_name], [Manager_id], [Phone_number], [Address], [Email], [Password]) VALUES (89, N'Sayed', N'Mohsen', 100, N'010112013', N'Giza', N's.mohsen59@email.com', N'23@2324')
INSERT [dbo].[Employee] ([Emp_id], [First_name], [Last_name], [Manager_id], [Phone_number], [Address], [Email], [Password]) VALUES (90, N'hany', N'hany', 100, N'010964782938', N'cairo', N'hanny@gmail.com', N'9898')
INSERT [dbo].[Employee] ([Emp_id], [First_name], [Last_name], [Manager_id], [Phone_number], [Address], [Email], [Password]) VALUES (91, N'omar', N'hany', 80, N'010964782931', NULL, N'omary@gmail.com', N'9898')
INSERT [dbo].[Employee] ([Emp_id], [First_name], [Last_name], [Manager_id], [Phone_number], [Address], [Email], [Password]) VALUES (92, N'Abdullah', N'Ahmed', 80, N'010112234', N'Giza', N'a.ahmed.mohammed@email.com', N'12345678')
INSERT [dbo].[Employee] ([Emp_id], [First_name], [Last_name], [Manager_id], [Phone_number], [Address], [Email], [Password]) VALUES (93, N'Halim', N'Saber', 80, N'019298244', N'Cairo', N'halim_saber@mail.com', N'12345678')
INSERT [dbo].[Employee] ([Emp_id], [First_name], [Last_name], [Manager_id], [Phone_number], [Address], [Email], [Password]) VALUES (94, N'ziad', N'youssef', 80, N'01113737144', N'giza', N'youssef@yahoo.cm', N'giza1')
INSERT [dbo].[Employee] ([Emp_id], [First_name], [Last_name], [Manager_id], [Phone_number], [Address], [Email], [Password]) VALUES (96, N'Hakim', N'Saher', 80, N'0192982442', NULL, N'hakim.saher@gmail.com', N'12345679')
INSERT [dbo].[Employee] ([Emp_id], [First_name], [Last_name], [Manager_id], [Phone_number], [Address], [Email], [Password]) VALUES (97, N'ashraf', N'youssef', 80, N'01113537144', N'giza', N'youssef@gmail.cm', N'giza1')
INSERT [dbo].[Employee] ([Emp_id], [First_name], [Last_name], [Manager_id], [Phone_number], [Address], [Email], [Password]) VALUES (98, N'ashraf', N'youssef', 102, N'01113537141', N'giza', N'yousef@gmail.cm', N'giza1')
INSERT [dbo].[Employee] ([Emp_id], [First_name], [Last_name], [Manager_id], [Phone_number], [Address], [Email], [Password]) VALUES (99, N'hakimi', N'youssef', 102, N'01113137141', N'alex', N'yousef@gmail.cm', N'giza1')
INSERT [dbo].[Employee] ([Emp_id], [First_name], [Last_name], [Manager_id], [Phone_number], [Address], [Email], [Password]) VALUES (100, N'Yousef', N'Joe', 102, N'0104321234', N'Cairo', N'yousef.joe@email.com', N'12345678')
INSERT [dbo].[Employee] ([Emp_id], [First_name], [Last_name], [Manager_id], [Phone_number], [Address], [Email], [Password]) VALUES (102, N'Khabiri', N'Hakeem', 80, N'0104321231', N'Cairo', N'khabiriiihakim29@email.com', N'12345678')
INSERT [dbo].[Employee] ([Emp_id], [First_name], [Last_name], [Manager_id], [Phone_number], [Address], [Email], [Password]) VALUES (103, N'Gamal', N'Gameel', 103, N'0104321243', N'Cairo', N'gamalgameel23@hotmail.com', N'12345678')
INSERT [dbo].[Employee] ([Emp_id], [First_name], [Last_name], [Manager_id], [Phone_number], [Address], [Email], [Password]) VALUES (104, N'galal', N'ashraf', 103, N'01113137151', N'alex', N'galall@gmail.cm', N'giza1')
INSERT [dbo].[Employee] ([Emp_id], [First_name], [Last_name], [Manager_id], [Phone_number], [Address], [Email], [Password]) VALUES (106, N'galal', N'yasser', 1, N'01213137151', N'alex', N'gello@gmail.cm', N'giza1')
INSERT [dbo].[Employee] ([Emp_id], [First_name], [Last_name], [Manager_id], [Phone_number], [Address], [Email], [Password]) VALUES (108, N'Soroor', N'H.', 1, N'0104321242', N'Cairo', N'sorror@hotmail.com', N'12345678')
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
SET IDENTITY_INSERT [dbo].[Inventory] ON 

INSERT [dbo].[Inventory] ([supplyID], [supply_Name], [Quantity], [Price]) VALUES (1, N'Razor Blade', 128, 1)
INSERT [dbo].[Inventory] ([supplyID], [supply_Name], [Quantity], [Price]) VALUES (2, N'Gel packet', 30, 10)
INSERT [dbo].[Inventory] ([supplyID], [supply_Name], [Quantity], [Price]) VALUES (3, N'Beard String', 3, 7)
INSERT [dbo].[Inventory] ([supplyID], [supply_Name], [Quantity], [Price]) VALUES (4, N'Shamboo', 6, 12)
INSERT [dbo].[Inventory] ([supplyID], [supply_Name], [Quantity], [Price]) VALUES (5, N'Barber Cape', 1, 5)
INSERT [dbo].[Inventory] ([supplyID], [supply_Name], [Quantity], [Price]) VALUES (6, N'Hair Dye', 0, 20)
SET IDENTITY_INSERT [dbo].[Inventory] OFF
GO
INSERT [dbo].[ManagedEmployees] ([EmpID], [OnDayOff]) VALUES (2, 1)
INSERT [dbo].[ManagedEmployees] ([EmpID], [OnDayOff]) VALUES (11, 0)
INSERT [dbo].[ManagedEmployees] ([EmpID], [OnDayOff]) VALUES (63, 1)
INSERT [dbo].[ManagedEmployees] ([EmpID], [OnDayOff]) VALUES (66, 0)
INSERT [dbo].[ManagedEmployees] ([EmpID], [OnDayOff]) VALUES (68, 0)
INSERT [dbo].[ManagedEmployees] ([EmpID], [OnDayOff]) VALUES (70, 0)
INSERT [dbo].[ManagedEmployees] ([EmpID], [OnDayOff]) VALUES (79, 0)
INSERT [dbo].[ManagedEmployees] ([EmpID], [OnDayOff]) VALUES (82, 0)
INSERT [dbo].[ManagedEmployees] ([EmpID], [OnDayOff]) VALUES (84, 0)
INSERT [dbo].[ManagedEmployees] ([EmpID], [OnDayOff]) VALUES (85, 0)
INSERT [dbo].[ManagedEmployees] ([EmpID], [OnDayOff]) VALUES (86, 0)
INSERT [dbo].[ManagedEmployees] ([EmpID], [OnDayOff]) VALUES (87, 0)
INSERT [dbo].[ManagedEmployees] ([EmpID], [OnDayOff]) VALUES (89, 0)
INSERT [dbo].[ManagedEmployees] ([EmpID], [OnDayOff]) VALUES (90, 0)
INSERT [dbo].[ManagedEmployees] ([EmpID], [OnDayOff]) VALUES (91, 0)
INSERT [dbo].[ManagedEmployees] ([EmpID], [OnDayOff]) VALUES (92, 0)
INSERT [dbo].[ManagedEmployees] ([EmpID], [OnDayOff]) VALUES (93, 0)
INSERT [dbo].[ManagedEmployees] ([EmpID], [OnDayOff]) VALUES (94, 0)
INSERT [dbo].[ManagedEmployees] ([EmpID], [OnDayOff]) VALUES (96, 0)
INSERT [dbo].[ManagedEmployees] ([EmpID], [OnDayOff]) VALUES (97, 0)
INSERT [dbo].[ManagedEmployees] ([EmpID], [OnDayOff]) VALUES (98, 0)
INSERT [dbo].[ManagedEmployees] ([EmpID], [OnDayOff]) VALUES (99, 0)
INSERT [dbo].[ManagedEmployees] ([EmpID], [OnDayOff]) VALUES (104, 0)
INSERT [dbo].[ManagedEmployees] ([EmpID], [OnDayOff]) VALUES (106, 0)
GO
INSERT [dbo].[Manager] ([Emp_id]) VALUES (1)
INSERT [dbo].[Manager] ([Emp_id]) VALUES (11)
INSERT [dbo].[Manager] ([Emp_id]) VALUES (80)
INSERT [dbo].[Manager] ([Emp_id]) VALUES (100)
INSERT [dbo].[Manager] ([Emp_id]) VALUES (102)
INSERT [dbo].[Manager] ([Emp_id]) VALUES (103)
INSERT [dbo].[Manager] ([Emp_id]) VALUES (106)
INSERT [dbo].[Manager] ([Emp_id]) VALUES (108)
GO
INSERT [dbo].[Offers] ([Service_id], [Start_date], [End_date]) VALUES (1, CAST(N'2024-12-28' AS Date), CAST(N'2024-12-28' AS Date))
INSERT [dbo].[Offers] ([Service_id], [Start_date], [End_date]) VALUES (1, CAST(N'2024-12-29' AS Date), CAST(N'2024-12-30' AS Date))
INSERT [dbo].[Offers] ([Service_id], [Start_date], [End_date]) VALUES (1, CAST(N'2024-12-31' AS Date), CAST(N'2025-01-03' AS Date))
GO
SET IDENTITY_INSERT [dbo].[Payment_Transaction] ON 

INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (1, N'incoming', N'cash', N'Pending', 5)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (2, N'incoming', N'cash', N'Pending', 3)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (3, N'incoming', N'cash', N'Pending', 3)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (4, N'incoming', N'cash', N'Pending', 3)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (5, N'incoming', N'cash', N'Pending', 5)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (6, N'incoming', N'cash', N'Pending', 3)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (7, N'incoming', N'cash', N'Pending', 4)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (8, N'incoming', N'cash', N'Pending', 4)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (9, N'incoming', N'cash', N'Pending', 4)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (10, N'incoming', N'online', N'Pending', 4)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (11, N'incoming', N'cash', N'Pending', 4)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (12, N'incoming', N'points', N'Pending', 3)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (13, N'incoming', N'cash', N'Pending', 6)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (14, N'incoming', N'cash', N'Pending', 3)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (15, N'incoming', N'cash', N'Pending', 4)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (16, N'incoming', N'cash', N'Pending', 4)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (17, N'incoming', N'cash', N'Pending', 3)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (18, N'incoming', N'cash', N'Pending', 4)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (19, N'incoming', N'cash', N'Pending', 4)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (20, N'Supply', N'Offline', N'Paid', 1230)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (23, N'Supply', N'Offline', N'Paid', 105)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (24, N'incoming', N'cash', N'Pending', 4)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (25, N'incoming', N'cash', N'Pending', 2)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (26, N'incoming', N'cash', N'Pending', 5)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (27, N'incoming', N'cash', N'Pending', 5)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (28, N'incoming', N'cash', N'Pending', 2)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (29, N'Supply', N'Offline', N'Paid', 5)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (30, N'Supply', N'Offline', N'Paid', 20)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (31, N'incoming', N'cash', N'Pending', 3)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (32, N'incoming', N'online', N'Pending', 4)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (33, N'incoming', N'online', N'Pending', 4)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (34, N'incoming', N'online', N'Pending', 4)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (35, N'incoming', N'online', N'Pending', 3)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (36, N'Appointment', N'cash', N'Pending', 4)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (37, N'Appointment', N'online', N'Pending', 6)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (38, N'Appointment', N'points', N'Pending', 3)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (39, N'Appointment', N'points', N'Pending', 4)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (40, N'Appointment', N'points', N'Pending', 5)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (41, N'Appointment', N'points', N'Pending', 4)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (42, N'Appointment', N'points', N'Pending', 4)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (43, N'Appointment', N'Cash', N'Pending', 10)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (44, N'Appointment', N'points', N'Pending', 7)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (45, N'Appointment', N'Cash', N'Pending', 15)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (46, N'Appointment', N'points', N'Pending', 7)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (47, N'Appointment', N'Cash', N'Pending', 15)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (48, N'Appointment', N'points', N'Pending', 4)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (49, N'Appointment', N'points', N'Pending', 5)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (50, N'Appointment', N'points', N'Pending', 5)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (51, N'Appointment', N'points', N'Pending', 5)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (52, N'Appointment', N'points', N'Pending', 5)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (53, N'Appointment', N'Cash', N'Pending', 15)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (54, N'Appointment', N'Cash', N'Pending', 15)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (55, N'Appointment', N'Cash', N'Pending', 15)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (56, N'Appointment', N'Cash', N'Pending', 15)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (57, N'Appointment', N'Cash', N'Pending', 15)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (58, N'Appointment', N'Cash', N'Pending', 15)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (59, N'Appointment', N'Cash', N'Pending', 15)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (60, N'Appointment', N'Cash', N'Pending', 15)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (61, N'Appointment', N'Cash', N'Pending', 15)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (62, N'Appointment', N'Cash', N'Pending', 15)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (63, N'Appointment', N'Cash', N'Pending', 15)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (64, N'Appointment', N'Cash', N'Pending', 15)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (65, N'Appointment', N'Cash', N'Done', 15)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (66, N'Appointment', N'Cash', N'Pending', 8)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (67, N'Appointment', N'Cash', N'Done', 15)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (68, N'Appointment', N'Cash', N'Done', 8)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (69, N'Supply', N'Offline', N'Paid', 20)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (70, N'Appointment', N'cash', N'Pending', 4)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (71, N'Appointment', N'cash', N'Done', 7)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (72, N'Appointment', N'cash', N'Done', 6)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (73, N'Appointment', N'points', N'Pending', 3)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (74, N'Appointment', N'online', N'Pending', 3)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (75, N'Appointment', N'cash', N'Done', 3)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (76, N'Appointment', N'online', N'Pending', 1)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (77, N'Appointment', N'points', N'Pending', 1)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (78, N'Appointment', N'cash', N'Done', 4)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (79, N'Appointment', N'cash', N'Done', 3)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (80, N'Appointment', N'cash', N'Done', 3)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (81, N'Appointment', N'cash', N'Done', 4)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (82, N'Appointment', N'cash', N'Done', 1)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (83, N'Appointment', N'online', N'Pending', 2)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (84, N'Supply', N'Offline', N'Paid', 15)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (85, N'Appointment', N'points', N'Pending', 1)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (86, N'Appointment', N'cash', N'Done', 1)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (87, N'Appointment', N'online', N'Pending', 4)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (88, N'Appointment', N'Cash', N'Done', 30)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (89, N'Supply', N'Offline', N'Paid', 500)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (90, N'Supply', N'Offline', N'Paid', 30)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (91, N'Appointment', N'Cash', N'Pending', 150)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (92, N'Appointment', N'Cash', N'Pending', 150)
INSERT [dbo].[Payment_Transaction] ([payment_id], [type], [payment_method], [status], [amount]) VALUES (93, N'Appointment', N'Cash', N'Pending', 150)
SET IDENTITY_INSERT [dbo].[Payment_Transaction] OFF
GO
INSERT [dbo].[PhoneAppointment] ([EmpID], [AppID], [CustName]) VALUES (63, 34, N'Yousef Off')
INSERT [dbo].[PhoneAppointment] ([EmpID], [AppID], [CustName]) VALUES (63, 35, N'Test')
INSERT [dbo].[PhoneAppointment] ([EmpID], [AppID], [CustName]) VALUES (63, 36, N'Hello')
INSERT [dbo].[PhoneAppointment] ([EmpID], [AppID], [CustName]) VALUES (63, 37, N'Test22')
INSERT [dbo].[PhoneAppointment] ([EmpID], [AppID], [CustName]) VALUES (63, 53, N'Yousef Offline3')
INSERT [dbo].[PhoneAppointment] ([EmpID], [AppID], [CustName]) VALUES (63, 54, N'Test')
INSERT [dbo].[PhoneAppointment] ([EmpID], [AppID], [CustName]) VALUES (63, 55, N'test3')
INSERT [dbo].[PhoneAppointment] ([EmpID], [AppID], [CustName]) VALUES (63, 56, N'test4')
GO
INSERT [dbo].[Receptionist] ([Emp_id]) VALUES (63)
INSERT [dbo].[Receptionist] ([Emp_id]) VALUES (79)
INSERT [dbo].[Receptionist] ([Emp_id]) VALUES (86)
INSERT [dbo].[Receptionist] ([Emp_id]) VALUES (93)
INSERT [dbo].[Receptionist] ([Emp_id]) VALUES (94)
INSERT [dbo].[Receptionist] ([Emp_id]) VALUES (96)
INSERT [dbo].[Receptionist] ([Emp_id]) VALUES (97)
INSERT [dbo].[Receptionist] ([Emp_id]) VALUES (98)
INSERT [dbo].[Receptionist] ([Emp_id]) VALUES (99)
INSERT [dbo].[Receptionist] ([Emp_id]) VALUES (104)
INSERT [dbo].[Receptionist] ([Emp_id]) VALUES (106)
GO
INSERT [dbo].[ReceptionistPayment] ([PaymentID], [EmpID]) VALUES (65, 63)
INSERT [dbo].[ReceptionistPayment] ([PaymentID], [EmpID]) VALUES (67, 63)
INSERT [dbo].[ReceptionistPayment] ([PaymentID], [EmpID]) VALUES (68, 63)
INSERT [dbo].[ReceptionistPayment] ([PaymentID], [EmpID]) VALUES (71, 63)
INSERT [dbo].[ReceptionistPayment] ([PaymentID], [EmpID]) VALUES (72, 63)
INSERT [dbo].[ReceptionistPayment] ([PaymentID], [EmpID]) VALUES (75, 63)
INSERT [dbo].[ReceptionistPayment] ([PaymentID], [EmpID]) VALUES (78, 63)
INSERT [dbo].[ReceptionistPayment] ([PaymentID], [EmpID]) VALUES (79, 63)
INSERT [dbo].[ReceptionistPayment] ([PaymentID], [EmpID]) VALUES (80, 63)
INSERT [dbo].[ReceptionistPayment] ([PaymentID], [EmpID]) VALUES (81, 63)
INSERT [dbo].[ReceptionistPayment] ([PaymentID], [EmpID]) VALUES (82, 63)
INSERT [dbo].[ReceptionistPayment] ([PaymentID], [EmpID]) VALUES (86, 63)
INSERT [dbo].[ReceptionistPayment] ([PaymentID], [EmpID]) VALUES (88, 63)
GO
SET IDENTITY_INSERT [dbo].[Service] ON 

INSERT [dbo].[Service] ([service_id], [service_name], [price]) VALUES (1, N'Haircut', 100)
INSERT [dbo].[Service] ([service_id], [service_name], [price]) VALUES (2, N'Beard Trim', 50)
INSERT [dbo].[Service] ([service_id], [service_name], [price]) VALUES (3, N'Shaving', 75)
INSERT [dbo].[Service] ([service_id], [service_name], [price]) VALUES (4, N'Hair Color', 75)
INSERT [dbo].[Service] ([service_id], [service_name], [price]) VALUES (5, N'Facial', 50)
INSERT [dbo].[Service] ([service_id], [service_name], [price]) VALUES (6, N'Hair Wash', 50)
INSERT [dbo].[Service] ([service_id], [service_name], [price]) VALUES (7, N'Scalp Treatment', 150)
SET IDENTITY_INSERT [dbo].[Service] OFF
GO
INSERT [dbo].[ServiceConsumes] ([ServiceID], [SupplyID], [QuantityConsumed]) VALUES (1, 5, 1)
INSERT [dbo].[ServiceConsumes] ([ServiceID], [SupplyID], [QuantityConsumed]) VALUES (2, 1, 1)
INSERT [dbo].[ServiceConsumes] ([ServiceID], [SupplyID], [QuantityConsumed]) VALUES (3, 1, 2)
INSERT [dbo].[ServiceConsumes] ([ServiceID], [SupplyID], [QuantityConsumed]) VALUES (4, 6, 1)
INSERT [dbo].[ServiceConsumes] ([ServiceID], [SupplyID], [QuantityConsumed]) VALUES (5, 3, 2)
INSERT [dbo].[ServiceConsumes] ([ServiceID], [SupplyID], [QuantityConsumed]) VALUES (6, 2, 1)
INSERT [dbo].[ServiceConsumes] ([ServiceID], [SupplyID], [QuantityConsumed]) VALUES (7, 4, 3)
GO
INSERT [dbo].[SuppliesBought] ([PaymentID], [SupplyID], [QuanityBought]) VALUES (20, 4, 3)
INSERT [dbo].[SuppliesBought] ([PaymentID], [SupplyID], [QuanityBought]) VALUES (23, 4, 3)
INSERT [dbo].[SuppliesBought] ([PaymentID], [SupplyID], [QuanityBought]) VALUES (29, 5, 1)
INSERT [dbo].[SuppliesBought] ([PaymentID], [SupplyID], [QuanityBought]) VALUES (30, 1, 2)
INSERT [dbo].[SuppliesBought] ([PaymentID], [SupplyID], [QuanityBought]) VALUES (69, 1, 2)
INSERT [dbo].[SuppliesBought] ([PaymentID], [SupplyID], [QuanityBought]) VALUES (84, 3, 1)
INSERT [dbo].[SuppliesBought] ([PaymentID], [SupplyID], [QuanityBought]) VALUES (89, 2, 20)
INSERT [dbo].[SuppliesBought] ([PaymentID], [SupplyID], [QuanityBought]) VALUES (90, 3, 2)
GO
INSERT [dbo].[Supply_Request] ([barber_id], [supply_id], [date], [quantity], [manager_id], [status]) VALUES (2, 1, CAST(N'2024-12-26' AS Date), 123, 1, N'Accepted')
INSERT [dbo].[Supply_Request] ([barber_id], [supply_id], [date], [quantity], [manager_id], [status]) VALUES (2, 1, CAST(N'2024-12-27' AS Date), 2, 11, N'Accepted')
INSERT [dbo].[Supply_Request] ([barber_id], [supply_id], [date], [quantity], [manager_id], [status]) VALUES (2, 2, CAST(N'2024-12-26' AS Date), 3, 11, N'Accepted')
INSERT [dbo].[Supply_Request] ([barber_id], [supply_id], [date], [quantity], [manager_id], [status]) VALUES (2, 2, CAST(N'2024-12-27' AS Date), 20, 11, N'Accepted')
INSERT [dbo].[Supply_Request] ([barber_id], [supply_id], [date], [quantity], [manager_id], [status]) VALUES (2, 3, CAST(N'2024-12-27' AS Date), 2, 11, N'Accepted')
INSERT [dbo].[Supply_Request] ([barber_id], [supply_id], [date], [quantity], [manager_id], [status]) VALUES (2, 4, CAST(N'2024-12-27' AS Date), 3, 11, N'Accepted')
INSERT [dbo].[Supply_Request] ([barber_id], [supply_id], [date], [quantity], [manager_id], [status]) VALUES (2, 5, CAST(N'2024-12-27' AS Date), 1, 11, N'Accepted')
INSERT [dbo].[Supply_Request] ([barber_id], [supply_id], [date], [quantity], [manager_id], [status]) VALUES (70, 3, CAST(N'2024-12-28' AS Date), 1, 1, N'Accepted')
GO
INSERT [dbo].[Username_and_Password] ([Username], [Password]) VALUES (N'T', N'12')
INSERT [dbo].[Username_and_Password] ([Username], [Password]) VALUES (N'Yousef', N'123')
INSERT [dbo].[Username_and_Password] ([Username], [Password]) VALUES (N'ziad', N'1234')
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__tmp_ms_x__17A35CA41D364E45]    Script Date: 28/12/2024 08:46:45 ******/
ALTER TABLE [dbo].[Customer] ADD UNIQUE NONCLUSTERED 
(
	[Phone_Number] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__tmp_ms_x__A9D10534627803CF]    Script Date: 28/12/2024 08:46:45 ******/
ALTER TABLE [dbo].[Customer] ADD UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Employee__7E87EC6737F206A7]    Script Date: 28/12/2024 08:46:45 ******/
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [UQ__Employee__7E87EC6737F206A7] UNIQUE NONCLUSTERED 
(
	[Phone_number] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Appointment] ADD  CONSTRAINT [DF_Appointment_Status]  DEFAULT ('Pending') FOR [Status]
GO
ALTER TABLE [dbo].[DaysOffRequest] ADD  CONSTRAINT [DF_DaysOffRequest_Status]  DEFAULT ('Pending') FOR [Status]
GO
ALTER TABLE [dbo].[Inventory] ADD  CONSTRAINT [DF_Inventory_Quantity]  DEFAULT ((0)) FOR [Quantity]
GO
ALTER TABLE [dbo].[Inventory] ADD  DEFAULT ((0)) FOR [Price]
GO
ALTER TABLE [dbo].[ManagedEmployees] ADD  CONSTRAINT [DF_ManagedEmployees_OnDayOff]  DEFAULT ((0)) FOR [OnDayOff]
GO
ALTER TABLE [dbo].[Payment_Transaction] ADD  CONSTRAINT [DF_Payment_Transaction_status]  DEFAULT ('Pending') FOR [status]
GO
ALTER TABLE [dbo].[PhoneAppointment] ADD  DEFAULT ((-1)) FOR [EmpID]
GO
ALTER TABLE [dbo].[ReceptionistPayment] ADD  DEFAULT ((-1)) FOR [EmpID]
GO
ALTER TABLE [dbo].[Supply_Request] ADD  CONSTRAINT [DF_Supply_Request_status]  DEFAULT ('Pending') FOR [status]
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD  CONSTRAINT [FK__Appointme__Servi__634EBE90] FOREIGN KEY([ServiceID])
REFERENCES [dbo].[Service] ([service_id])
GO
ALTER TABLE [dbo].[Appointment] CHECK CONSTRAINT [FK__Appointme__Servi__634EBE90]
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD  CONSTRAINT [FK_Appointment_Barber] FOREIGN KEY([BarberID])
REFERENCES [dbo].[Barber] ([Emp_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Appointment] CHECK CONSTRAINT [FK_Appointment_Barber]
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD  CONSTRAINT [FK_Appointment_Customer] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customer] ([CustID])
GO
ALTER TABLE [dbo].[Appointment] CHECK CONSTRAINT [FK_Appointment_Customer]
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD  CONSTRAINT [FK_Appointment_Payment_Transaction] FOREIGN KEY([PaymentID])
REFERENCES [dbo].[Payment_Transaction] ([payment_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Appointment] CHECK CONSTRAINT [FK_Appointment_Payment_Transaction]
GO
ALTER TABLE [dbo].[Attendance_Log]  WITH CHECK ADD  CONSTRAINT [FK__Attendanc__emp_i__55009F39] FOREIGN KEY([emp_id])
REFERENCES [dbo].[Barber] ([Emp_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Attendance_Log] CHECK CONSTRAINT [FK__Attendanc__emp_i__55009F39]
GO
ALTER TABLE [dbo].[Barber]  WITH CHECK ADD  CONSTRAINT [FK_Barber_ManagedEmployees] FOREIGN KEY([Emp_id])
REFERENCES [dbo].[ManagedEmployees] ([EmpID])
GO
ALTER TABLE [dbo].[Barber] CHECK CONSTRAINT [FK_Barber_ManagedEmployees]
GO
ALTER TABLE [dbo].[DaysOffRequest]  WITH CHECK ADD  CONSTRAINT [FK_DaysOffRequest_ManagedEmployees] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[ManagedEmployees] ([EmpID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DaysOffRequest] CHECK CONSTRAINT [FK_DaysOffRequest_ManagedEmployees]
GO
ALTER TABLE [dbo].[DaysOffRequest]  WITH CHECK ADD  CONSTRAINT [FK_DaysOffRequest_Manager] FOREIGN KEY([ManagerID])
REFERENCES [dbo].[Manager] ([Emp_id])
GO
ALTER TABLE [dbo].[DaysOffRequest] CHECK CONSTRAINT [FK_DaysOffRequest_Manager]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Manager] FOREIGN KEY([Manager_id])
REFERENCES [dbo].[Manager] ([Emp_id])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Manager]
GO
ALTER TABLE [dbo].[ManagedEmployees]  WITH CHECK ADD  CONSTRAINT [FK_ManagedEmployees_Employee] FOREIGN KEY([EmpID])
REFERENCES [dbo].[Employee] ([Emp_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ManagedEmployees] CHECK CONSTRAINT [FK_ManagedEmployees_Employee]
GO
ALTER TABLE [dbo].[Manager]  WITH CHECK ADD  CONSTRAINT [FK_Managr_Employee] FOREIGN KEY([Emp_id])
REFERENCES [dbo].[Employee] ([Emp_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Manager] CHECK CONSTRAINT [FK_Managr_Employee]
GO
ALTER TABLE [dbo].[Offers]  WITH CHECK ADD  CONSTRAINT [FK_Offers_Service] FOREIGN KEY([Service_id])
REFERENCES [dbo].[Service] ([service_id])
GO
ALTER TABLE [dbo].[Offers] CHECK CONSTRAINT [FK_Offers_Service]
GO
ALTER TABLE [dbo].[PhoneAppointment]  WITH CHECK ADD  CONSTRAINT [FK__Reception__EmpID__2704CA5F] FOREIGN KEY([EmpID])
REFERENCES [dbo].[Receptionist] ([Emp_id])
ON UPDATE CASCADE
ON DELETE SET DEFAULT
GO
ALTER TABLE [dbo].[PhoneAppointment] CHECK CONSTRAINT [FK__Reception__EmpID__2704CA5F]
GO
ALTER TABLE [dbo].[Receptionist]  WITH CHECK ADD  CONSTRAINT [FK_Receptionist_ManagedEmployees] FOREIGN KEY([Emp_id])
REFERENCES [dbo].[ManagedEmployees] ([EmpID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Receptionist] CHECK CONSTRAINT [FK_Receptionist_ManagedEmployees]
GO
ALTER TABLE [dbo].[ReceptionistPayment]  WITH CHECK ADD FOREIGN KEY([EmpID])
REFERENCES [dbo].[Receptionist] ([Emp_id])
ON UPDATE CASCADE
ON DELETE SET DEFAULT
GO
ALTER TABLE [dbo].[ReceptionistPayment]  WITH CHECK ADD  CONSTRAINT [FK_ReceptionistPayment_Payment_Transaction] FOREIGN KEY([PaymentID])
REFERENCES [dbo].[Payment_Transaction] ([payment_id])
GO
ALTER TABLE [dbo].[ReceptionistPayment] CHECK CONSTRAINT [FK_ReceptionistPayment_Payment_Transaction]
GO
ALTER TABLE [dbo].[ServiceConsumes]  WITH CHECK ADD  CONSTRAINT [FK__ServiceCo__Servi__2DB1C7EE] FOREIGN KEY([ServiceID])
REFERENCES [dbo].[Service] ([service_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ServiceConsumes] CHECK CONSTRAINT [FK__ServiceCo__Servi__2DB1C7EE]
GO
ALTER TABLE [dbo].[ServiceConsumes]  WITH CHECK ADD  CONSTRAINT [FK__ServiceCo__Suppl__2EA5EC27] FOREIGN KEY([SupplyID])
REFERENCES [dbo].[Inventory] ([supplyID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ServiceConsumes] CHECK CONSTRAINT [FK__ServiceCo__Suppl__2EA5EC27]
GO
ALTER TABLE [dbo].[SuppliesBought]  WITH CHECK ADD  CONSTRAINT [FK__SuppliesB__Payme__1C873BEC] FOREIGN KEY([PaymentID])
REFERENCES [dbo].[Payment_Transaction] ([payment_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SuppliesBought] CHECK CONSTRAINT [FK__SuppliesB__Payme__1C873BEC]
GO
ALTER TABLE [dbo].[SuppliesBought]  WITH CHECK ADD  CONSTRAINT [FK__SuppliesB__Suppl__1D7B6025] FOREIGN KEY([SupplyID])
REFERENCES [dbo].[Inventory] ([supplyID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SuppliesBought] CHECK CONSTRAINT [FK__SuppliesB__Suppl__1D7B6025]
GO
ALTER TABLE [dbo].[Supply_Request]  WITH CHECK ADD  CONSTRAINT [FK__Supply_Re__barbe__57DD0BE4] FOREIGN KEY([barber_id])
REFERENCES [dbo].[Barber] ([Emp_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Supply_Request] CHECK CONSTRAINT [FK__Supply_Re__barbe__57DD0BE4]
GO
ALTER TABLE [dbo].[Supply_Request]  WITH CHECK ADD  CONSTRAINT [FK__Supply_Re__suppl__58D1301D] FOREIGN KEY([supply_id])
REFERENCES [dbo].[Inventory] ([supplyID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Supply_Request] CHECK CONSTRAINT [FK__Supply_Re__suppl__58D1301D]
GO
ALTER TABLE [dbo].[Supply_Request]  WITH CHECK ADD  CONSTRAINT [FK_Supply_Request_Manager] FOREIGN KEY([manager_id])
REFERENCES [dbo].[Manager] ([Emp_id])
GO
ALTER TABLE [dbo].[Supply_Request] CHECK CONSTRAINT [FK_Supply_Request_Manager]
GO
ALTER DATABASE [Barbershop Operations Platform DB] SET  READ_WRITE 
GO
